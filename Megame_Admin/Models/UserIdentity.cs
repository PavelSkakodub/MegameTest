using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Megame_Admin.Models
{
    public class UserIdentity : IdentityUser
    {
        //никнейм
        //емейл
        //номер телефона
        //...

        public DateTime RegistrationDate { get; set; }

        //информация по профилю (связь 1 к 1)
        public BaseUser BaseUser { get; set; }
        //связи 1 к многим
        public List<Skill> Skills { get; set; }
        public List<WorkPlatform> WorkPlatforms { get; set; }        
        public List<Contact> Friends { get; set; }
        public List<Chat> Chats { get; set; }
        
        //public List<UsersChats> UsersChats { get; set; }
        public List<Message> Messages { get; set; }
    }

    public class BaseUser
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Profession { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Bio { get; set; }
        public string Country { get; set; }
        public string Adress { get; set; }
        public string Location { get; set; }
        public string Website { get; set; }
        public string Linkedin { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Github { get; set; }

        //связь 1 к 1
        public string UserIdentityKey { get; set; } 
        public UserIdentity UserIdentity { get; set; }
    }

    public class Skill
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public sbyte Percent { get; set; }

        //связь 1 к 1
        public string UserIdentityKey { get; set; }
        public UserIdentity UserIdentity { get; set; }
    }

    public class WorkPlatform
    {
        public int Id { get; set; }
        public string PlatformTitle { get; set; }
        public string Description { get; set; }

        //связь 1 к 1
        public string UserIdentityKey { get; set; }
        public UserIdentity UserIdentity { get; set; }
    }

    public class Contact
    {
        public int Id { get; set; }
        public string UserIdentityId { get; set; }
        public UserIdentity UserIdentity { get; set; }
        public string FriendId { get; set; }
    }

    public class Chat
    {
        public int Id { get; set; }        

        public string Name { get; set; }
        public List<UserIdentity> Users { get; set; }
        public List<Message> Messages { get; set; }
    }

    public class Message
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime Time { get; set; }        

        public string UserId { get; set; }
        public UserIdentity UserIdentity { get; set; }

        public int ChatId { get; set; }
        public Chat Chat { get; set; }
        
    }

    //public class UsersChats
    //{
    //    public string UserId { get; set; }
    //    public UserIdentity User { get; set; }

    //    public int ChatId { get; set; }
    //    public Chat Chat { get; set; }
    //}
}

