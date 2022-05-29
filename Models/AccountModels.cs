using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Megame_Admin.Models
{
    public class EmailConfirm //модель для отправки подтверждения почты
    {
        public string UserName { get; set; }
        public string CallbackUrl { get; set; }
        public string Email { get; set; }
        public System.DateTime Date { get; set; }
    }

    public class LoginModel //модель для авторизации юзера
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }

    public class RegisterModel //модель для регистрации юзера
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsOperator { get; set; }
    }

    public class ResetPassword //модель для сброса пароля по форме
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }

    public class SettingsModel
    {
        public IFormFile File { get; set; }
        public string FullName { get; set; }
        public int DayBirthday { get; set; }
        public int MonthBirthday { get; set; }
        public int YearBirthday { get; set; }
        public string Profession { get; set; }
        public string Bio { get; set; }
        public string Counrty { get; set; }
        public string Adress { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Linkedin { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Github { get; set; }
    }
}
