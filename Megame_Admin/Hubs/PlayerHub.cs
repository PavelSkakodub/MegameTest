using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Megame_Admin.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Megame_Admin.Hubs
{
    public class PlayerHub:Hub
    {
        //хранение списка подключений
        private readonly static ConnectionMapping<string> connections = new ConnectionMapping<string>();
                
        //метод отправки сообщения от сервера к игроку
        public async void SendToUnity(string username, string message)
        {
            var operatorName = Context.User.Identity.Name;

            //отправляем сообщение игроку по всем его подключениям с передачей ника оператора
            foreach (var connectionId in connections.GetConnections(username))
            {
                await Clients.Client(connectionId).SendAsync("UnityReceiveMessage", operatorName, message);
            }

            //отправка запроса на пометку сообщений игрока прочитанными
            HttpClient client = new HttpClient() { BaseAddress = new Uri("https://localhost:44395/api/") };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //генерация post запроса и отправка
            var json = JsonConvert.SerializeObject(username);
            var data = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PostAsync("messages/set-view-player-messages", data);            

            //сохранение сообщения в БД
            using DbContext context = new DbContext();
            //ищем игрока которому отправляем сообщение
            var player = await context.Players
                .Include(x => x.PlayerMessages)
                .FirstOrDefaultAsync(x => x.Username == username);
            //добавляем сообщение игроку от оператора
            player.PlayerMessages.Add(new PlayerMessage
            {
                Username = operatorName,
                Body = message,
                MessageType = MessageType.Operator,
                Time = DateTime.Now,
                IsRead = false
            });
            //сохраняем изменения
            await context.SaveChangesAsync();
        }

        //метод приёма сообщений от игроков
        public async void SendFromUnity(string username, string message)
        {
            //при каждом сообщении обновляем/добавляем айди подключения
            connections.Add(username, Context.ConnectionId);
            //отправка всем операторам (т.к любой может ответить)
            await Clients.All.SendAsync("ServerReceiveMessage", username, message);
            //ищем игрока в БД
            using DbContext context = new DbContext();
            var player = await context.Players
                .Include(x => x.PlayerMessages)
                .FirstOrDefaultAsync(x => x.Username == username);
            //сохраняем сообщение у игрока
            player.PlayerMessages.Add(new PlayerMessage
            {
                Username = player.Username,
                Body = message,
                MessageType = MessageType.Player,
                Time = DateTime.Now,
                IsRead = false
            });
            //сохраняем изменения
            await context.SaveChangesAsync();
        }
        
        
        //ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost"); //нет установленного redis
    }
}
