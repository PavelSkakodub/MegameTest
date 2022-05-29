using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Megame_Admin.Models
{
    //реализация собственного UserManager 
    public class AppUserManager : UserManager<UserIdentity> //наследуемся от базового класса с типом нашего юзера
    {
        //конструктор менеджера с параметрами настройками (передаёт все настройки в базовый класс)
        public AppUserManager(IUserStore<UserIdentity> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<UserIdentity> passwordHasher, IEnumerable<IUserValidator<UserIdentity>> userValidators, IEnumerable<IPasswordValidator<UserIdentity>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<UserIdentity>> logger)
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
    
        }

        //метод для получения юзера с его данными BaseUser
        public async Task<UserIdentity> GetUserIdentityAsync(ClaimsPrincipal User)
        {
            //получаем юзера через св-во User (авториз.пользовтеля)
            var user = await GetUserAsync(User);
            //извлекаем юзера с его связанными данными (с возможностью считывать их)
            var userIdentity = await Users
                .Include(x => x.BaseUser)
                .Include(x => x.WorkPlatforms)
                .Include(x => x.Skills)
                .Include(x => x.Friends)
                .Include(x => x.Chats)
                .FirstOrDefaultAsync(x => x.Id == user.Id);
            //возращаем юзера
            return userIdentity;
        }

        //добавление друга
        public async Task<bool> AddFriendAsync(ClaimsPrincipal User, string email)
        {
            using DbContext context = new DbContext();
            //получаем текущего юзера
            var user = await context.AppUsers
                .Include(x => x.Friends)
                .Include(x => x.Chats)
                .FirstOrDefaultAsync(x => x.UserName == User.Identity.Name); //GetUserIdentityAsync(User);
            //ищем указанного юзера
            var friend = await context.AppUsers
                .Include(x => x.Friends)
                .Include(x => x.Chats)
                .FirstOrDefaultAsync(x => x.Email == email);

            //если юзеров не нашлось
            if (user == null || friend == null) return false;
            //если юзера нет в друзьях - добавляем друг другу
            if (user.Friends.FirstOrDefault(x => x.FriendId == friend.Id) == null) 
            {
                //создаём чат между юзером  его другом
                Chat chat = new Chat
                {
                    Name = user.UserName + friend.UserName,
                    Users = new List<UserIdentity>() { user, friend },
                    Messages = new List<Message>()
                };

                //добавляем контакт обоим юзерам
                user.Friends.Add(new Contact { UserIdentityId = user.Id, FriendId = friend.Id });
                friend.Friends.Add(new Contact { UserIdentityId = friend.Id, FriendId = user.Id });

                //добавляем чат с юзерами в БД и сохраняем
                context.Chats.Add(chat);
                await context.SaveChangesAsync();
                //возврат успешного выполнения
                return true;
            }
            else return false;            
        }

        //получение списка друзей 
        public async Task<List<UserIdentity>> GetUserFriendsAsync(ClaimsPrincipal User)
        {
            using DbContext context = new DbContext();
            var user = await GetUserIdentityAsync(User);
            List<UserIdentity> friends = new List<UserIdentity>();
            for (int i = 0; i < user.Friends.Count; i++)
            {
                var f = await context.AppUsers
                    .Include(x => x.BaseUser)
                    .FirstOrDefaultAsync(x => x.Id == user.Friends[i].FriendId);
                friends.Add(f);
            }
            return friends;
        }

        //получение списка чатов юзера
        public async Task<List<Chat>> GetUserChatsAsync(ClaimsPrincipal User)
        {
            using DbContext context = new DbContext();
            //выбираем список чатов нашего юзера (никнейм в названии)
            var chats = context.Chats
                .Include(x => x.Users)
                .ThenInclude(x => x.BaseUser)
                .Include(x => x.Messages)
                .ThenInclude(x => x.UserIdentity)
                .Where(x => EF.Functions
                .Like(x.Name, $"%{User.Identity.Name}%"))
                .AsNoTracking();
            //возвращаем список чатов
            var result = await chats.ToListAsync();
            return result;
        }
    }
}
