using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DreamMessenger.Services;
using Megame_Admin.Models;
using Megame_Admin.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Megame_Admin.Controllers
{
    [Authorize(Roles = "Operator,Observer")]
    public class AccountController : Controller
    {
        private readonly AppUserManager userManager; //класс для работы с пользователями
        private readonly SignInManager<UserIdentity> signInManager; //класс с функциями аутентификации и пр.
        private readonly RoleManager<IdentityRole> roleManager; //класс управления ролями
        private readonly IViewRenderService viewRenderService; //сервис конверта html
        private readonly IEmailService emailService; //сервис отправки сообщений на почту
        private readonly IYandexCloudS3 yandexCloud; //сервис для работы с хранилищем 

        //настройки из конфигураций
        public IConfiguration Configuration { get; }

        //инициализация менеджеров
        public AccountController(AppUserManager userManager, SignInManager<UserIdentity> signInManager, RoleManager<IdentityRole> roleManager, IViewRenderService viewRenderService, IEmailService emailService, IYandexCloudS3 yandexCloud, IConfiguration Configuration)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.emailService = emailService;
            this.viewRenderService = viewRenderService;
            this.yandexCloud = yandexCloud;
            this.Configuration = Configuration;
        }


        #region HttpGet
        [HttpGet]
        [AllowAnonymous]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View("SignIn");
        }

        [HttpGet]
        public IActionResult Profile()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Settings()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            //удаляем аутентификационные куки
            await signInManager.SignOutAsync();
            //редиректим на страницу авторизации
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code) //подтверждение емейла по токену из почты юзера
        {
            //если пришли Id юзера и его токен
            if (userId != null && code != null)
            {
                //получаем юзера по переданному Id
                var user = await userManager.FindByIdAsync(userId);

                //если нашли юзера по его Id
                if (user != null)
                {
                    //делаем подтверждение емейла
                    var result = await userManager.ConfirmEmailAsync(user, code);
                    if (result.Succeeded) return RedirectToAction("Index", "Home");                    
                }
            }

            //если подтверждение не удалось возврат страницы с ошибкой
            return Content("Error");
        }

        #endregion


        #region HttpPost
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignUp(RegisterModel model)
        {
            if (ModelState.IsValid) //если валидация модели успешна
            {
                //создаём пользователя с его данными 
                UserIdentity user = new UserIdentity()
                {
                    UserName = model.Username,
                    Email = model.Email,
                    RegistrationDate = DateTime.UtcNow,
                    BaseUser = new BaseUser(),
                    Skills = new List<Skill>(),
                    WorkPlatforms = new List<WorkPlatform>(),
                    Friends = new List<Contact>(),
                    Messages = new List<Message>(),
                    Chats = new List<Chat>()                  
                };
                user.Skills.Add(new Skill() { Name = "C#", Percent = 70 });
                user.WorkPlatforms.Add(new WorkPlatform() { PlatformTitle = "Megame", Description = "I am creating an admin panel for Megame company. Implementation period 2 weeks." });
                //добавляем пользователя
                var result = await userManager.CreateAsync(user, model.Password);
                //если успешно добавили
                if (result.Succeeded)
                {
                    //добавляем роль юзеру, переданную из формы
                    await AddRoleUserAsync(user, model.IsOperator ? "Observer" : "Operator");
                    //генерируем уник.токен подтверждения
                    var code = userManager.GenerateEmailConfirmationTokenAsync(user);
                    //создаём url с передачей в него Id и токена подтверждения юзера - редирект на метод ConfirmEmail c арг .Id и token
                    var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code.Result }, protocol: HttpContext.Request.Scheme);

                    //создаём объект модели подтверждения почты
                    EmailConfirm confirmModel = new EmailConfirm()
                    {
                        UserName = model.Username,
                        CallbackUrl = callbackUrl,
                        Date = DateTime.Now,
                        Email = model.Email
                    };

                    //конвертируем переданное представление с моделью в html-страницу для отправки на почту
                    var htmlEmail = await viewRenderService.RenderToStringAsync("EmailConfirm", confirmModel);
                    //отправляем сообщение на емейл юзера с передачей страницы (сообщения)
                    await emailService.SendEmailAsync(model.Email, "Account confirmation", htmlEmail);

                    //возвращаем сообщение о завершениии регистрации
                    return Content("Confirm your email to complete registration.");
                }
                else
                {
                    //перебор и добавление ошибок в состояние модели
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            //если не удалось - возвращаем страницу
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignIn(LoginModel model) //авторизация пользователя
        {
            //получаем юзера по емейл
            var user = await userManager.FindByEmailAsync(model.Email);

            //если юзера нету
            if (user == null) 
            {
                ModelState.AddModelError(nameof(model.Email), "User is not found");
                return View();
            }

            //если емейл не подтверждён
            if (!user.EmailConfirmed)
            {
                ModelState.AddModelError(nameof(model.Email), "Confirm your email first");
                return View();
            }

            //если пользователь заблокирован при входе (время блокировки не прошло)
            if (user.LockoutEnd > DateTimeOffset.Now)
            {
                ModelState.AddModelError(string.Empty, "Too many login attempts. Repeat after 30 minutes");
                return View();
            }

            //авторизуемся, создавая файл cookie и возвращаем Task авторизации
            //isPersistent - флаг, указывающий, должен ли файл cookie для входа сохраняться после закрытия браузера
            //lockoutOnFailure - флаг, указывающий, следует ли блок. пользователя на время в случае неуд-ых попыток входа
            var result = await signInManager.PasswordSignInAsync(user, model.Password, isPersistent: model.RememberMe, lockoutOnFailure: true);
            //если задача не сработала
            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Invalid login or password");
                return View();
            }

            //обнуляем неудачные попытки входа
            user.AccessFailedCount = 0;

            //если успешно вошли редиректим
            return RedirectToAction("Index", "Home");
        }
        
        [HttpPost]
        public async Task<IActionResult> Settings(SettingsModel model) //редактирование настроек
        {            
            if (ModelState.IsValid)
            {                                             

                //загружаем картинку в хранилище
                if (model.File != null) await yandexCloud.PutObjectAsync(model.File.OpenReadStream(), model.File.FileName);
                //получаем пользователя со всеми его данными
                var user = await userManager.GetUserIdentityAsync(User);
                //если файл загрузили - то устанавливаем его - иначе оставляем
                if (model.File != null) user.BaseUser.Photo = Configuration["PathToBucket"] + model.File.FileName;
                user.BaseUser.FullName = model.FullName;
                user.BaseUser.Profession = model.Profession;
                user.BaseUser.Adress = model.Adress;
                user.BaseUser.Birthday = new DateTime(model.YearBirthday, model.MonthBirthday, model.DayBirthday);
                user.BaseUser.Bio = model.Bio;
                user.BaseUser.Country = model.Counrty;
                user.PhoneNumber = model.Phone;
                user.BaseUser.Location = model.Location;
                user.BaseUser.Website = model.Website;
                user.BaseUser.Facebook = model.Facebook;
                user.BaseUser.Twitter = model.Twitter;
                user.BaseUser.Linkedin = model.Linkedin;
                user.BaseUser.Github = model.Github;
                //сохраняем изменения
                await userManager.UpdateAsync(user);
                //возврат страницы
                return View();
            }
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> AddSkill(string name,int percent) //добавление скилов юзеру
        {
            var user = await userManager.GetUserIdentityAsync(User);
            user.Skills.Add(new Skill()
            {
                Name = name,
                Percent = (sbyte)percent
            });
            await userManager.UpdateAsync(user);
            return RedirectToAction("Settings");
        }
        
        [HttpPost]
        public async Task<IActionResult> AddWorkPlatform(string title, string description) //добавление опыта работы
        {
            var user = await userManager.GetUserIdentityAsync(User);
            user.WorkPlatforms.Add(new WorkPlatform()
            {
                PlatformTitle = title,
                Description = description
            });
            await userManager.UpdateAsync(user);
            return RedirectToAction("Settings");
        }

        [HttpPost]
        public async Task<IActionResult> Contacts(string email) //добавление контакта для переписки
        {
            if(await userManager.AddFriendAsync(User, email))
            {
                return View();
            }
            else
            {
                ModelState.AddModelError("", $"User {email} is not found  or is your friend");
                return View();
            }
            
        }
        #endregion


        //добавление роли юзеру
        private async Task AddRoleUserAsync(UserIdentity user, string role)
        {
            //если такой роли не сущ-ует - создать
            if (!await roleManager.RoleExistsAsync(role)) 
            {
                var Role = new IdentityRole() { Name = role, NormalizedName = role.ToLower() };
                await roleManager.CreateAsync(Role);
            }
            //добавляем роль к юзеру (сущ-ую или только созданную) 
            await userManager.AddToRoleAsync(user, role);            
        }
    }
}
