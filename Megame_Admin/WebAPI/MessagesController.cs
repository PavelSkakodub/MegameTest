using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Megame_Admin.WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {        
        [HttpGet]
        [Route("all-chats")] //получаем список всех игроков с инфой по сообщениям
        public async Task<JsonResult> GetAllChats() 
        {
            using DbContext context = new DbContext();
            var chats = await context.Players
                .Include(x => x.PlayerMessages)
                .Where(x => x.PlayerMessages.Count != 0)
                .Select(x => new
                {
                    Player = x.Username,
                    MessagesCount = x.PlayerMessages.Count, //кол-во всех сообщений
                    PlayerMessages = x.PlayerMessages //кол-во сообщений игрока
                .Where(x => x.MessageType == Models.MessageType.Player)
                .Count(),
                    MessagesNotView = x.PlayerMessages //кол-во непрочитанных сообщений игрока
                .Where(x => x.IsRead == false && x.MessageType == Models.MessageType.Player)
                .Count(),
                    LastMessage = x.PlayerMessages //время последнего сообщения                    
                    .Where(x => x.Time <= DateTime.Now)
                    .FirstOrDefault().Time
                }).ToListAsync(); //делаем выборку списком
            return new JsonResult(chats);
        }

        [HttpGet]
        [Route("all-messages/{token}")] //получаем список всех сообщений игрока с оператором
        public async Task<JsonResult> GetAllMessages(string token) 
        {
            using DbContext context = new DbContext();
            var messages = await context.PlayerMessages
                .Include(x => x.Player)
                .Where(x => x.Player.Token == token)
                .ToListAsync();
            return new JsonResult(messages);
        }

        [HttpGet]
        [Route("not-view-player-messages/{token}")] //получаем сообщения которые не прочитал оператор
        public async Task<JsonResult> GetNotViewPlayerMessages(string token) 
        {
            using DbContext context = new DbContext();
            var messages = await context.PlayerMessages
                .Include(x => x.Player)
                .Where(x => x.Player.Token == token
                && x.IsRead == false 
                && x.MessageType == Models.MessageType.Player)
                .ToListAsync();
            return new JsonResult(messages);
        }

        [HttpGet]
        [Route("not-view-operator-messages/{token}")] //получаем сообщения которые не прочитал игрок
        public async Task<JsonResult> GetNotViewOperatorMessages(string token)
        {
            using DbContext context = new DbContext();
            var messages = await context.PlayerMessages
                .Include(x => x.Player)
                .Where(x => x.Player.Token == token
                && x.IsRead == false
                && x.MessageType == Models.MessageType.Operator)
                .ToListAsync();
            return new JsonResult(messages);
        }


        [HttpPost]
        [Route("set-view-operator-messages")] //помечаем все сообщения от оператора прочитанными
        public async Task<bool> PostOperatorMessage([FromBody] string token) //для пометки в Unity
        {
            try
            {
                using DbContext context = new DbContext();
                //получаем список всех сообщений от игрока
                var messages = await context.PlayerMessages
                    .Include(x => x.Player)
                    .Where(x => x.Player.Token == token && x.MessageType == Models.MessageType.Operator)
                    .ToListAsync();
                //помечаем каждое сообщение прочитанным
                foreach (var m in messages) m.IsRead = true;
                //сохраняем изменения
                await context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }            
        }

        [HttpPost]
        [Route("set-view-player-messages")] //помечаем все сообщения от игрока прочитанными
        public async Task<bool> PostPlayerMessage([FromBody] string username) //для пометки на сервере
        {
            try
            {
                using DbContext context = new DbContext();
                //получаем список всех сообщений от игрока
                var messages = await context.PlayerMessages
                    .Include(x => x.Player)
                    .Where(x => x.Player.Username == username && x.MessageType == Models.MessageType.Player)
                    .ToListAsync();
                //помечаем каждое сообщение прочитанным
                foreach (var m in messages) m.IsRead = true;
                //сохраняем изменения
                await context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
