using Megame_Admin.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Megame_Admin.Hubs
{
    public class OperatorHub:Hub
    {
        //хранение списка подключений
        private readonly static ConnectionMapping<string> connections = new ConnectionMapping<string>();

        //отправка и сохранение сообщения
        public async Task SendChatMessage(string chat, string message)
        {
            using DbContext context = new DbContext();
            //никнейм юзера которому пишем
            string name = "";
            //получаем текущий чат
            var activeChat = await context.Chats
                .Include(x => x.Users)
                .Include(x => x.Messages)
                .FirstOrDefaultAsync(x => x.Name == chat);

            //выбираем из 2-ух участников другого (т.е не себя)
            if (activeChat.Users[0].UserName == Context.User.Identity.Name) name = activeChat.Users[1].UserName;            
            else name = activeChat.Users[0].UserName;
            //отправляем сообщение 2-му участнику для всех его подключений
            foreach (var connectionId in connections.GetConnections(name))
            {
                await Clients.Client(connectionId).SendAsync("ReceiveMessage", chat, message);
            } 

            //получаем текущего юзера                       
            var user = await context.Users.FirstOrDefaultAsync(x => x.UserName == Context.User.Identity.Name);
            //добавляем в текущий чат сообщение от текущего юзера
            activeChat.Messages.Add(new Message()
            {
                Body = message,
                Time = DateTime.Now,
                UserIdentity = user
            });
            //сохраняем изменения
            await context.SaveChangesAsync();            
        }

        //переопределение метода подклчения соединения
        public override Task OnConnectedAsync()
        {
            //сохраняем айди подключения в словарь
            string name = Context.User.Identity.Name;
            connections.Add(name, Context.ConnectionId);
            return base.OnConnectedAsync();
        }

        //переопределение метода разрыва соединения
        public override Task OnDisconnectedAsync(Exception ex)
        {
            //удаляем айди подключения
            string name = Context.User.Identity.Name;
            connections.Remove(name, Context.ConnectionId);
            return base.OnDisconnectedAsync(ex);
        }
    }
}
