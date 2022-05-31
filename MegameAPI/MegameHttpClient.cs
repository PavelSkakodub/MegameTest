using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MegameAPI
{
    public class MegameHttpClient : IDisposable
    {
        public string Url { get; } = "https://localhost:44395/api/";
        private readonly HttpClient client;

        public MegameHttpClient()
        {
            client = new HttpClient() { BaseAddress = new Uri(Url) };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void Dispose()
        {
            client.Dispose();
        }


        #region GetRequest
        //получение списка всех никнеймов
        public async Task<List<string>> GetUsernameListAsync()
        {
            var response = await client.GetAsync("auth");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<string>>(content);
            return result;
        }

        //получение игрока по токену
        public async Task<Player> GetPlayerAsync(string token)
        {
            var response = await client.GetAsync($"auth/{token}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Player>(content);
            return result;
        }

        //получение списка с инфой по чатам
        public async Task<List<AllChats>> GetAllChats()
        {
            var response = await client.GetAsync("messages/messages-all-chats");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<AllChats>>(content);
            return result;
        }

        //получаем список всех сообщений игрока с оператором
        public async Task<List<PlayerMessage>> GetAllMessages(string token)
        {
            var response = await client.GetAsync($"messages/all-messages/{token}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<PlayerMessage>>(content);
            return result;
        }

        //получаем сообщения которые не прочитал оператор
        public async Task<List<PlayerMessage>> GetNotViewPlayerMessages(string token)
        {
            var response = await client.GetAsync($"messages/not-view-player-messages/{token}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<PlayerMessage>>(content);
            return result;
        }

        //получаем сообщения которые не прочитал игрок
        public async Task<List<PlayerMessage>> GetNotViewOperatorMessages(string token)
        {
            var response = await client.GetAsync($"messages/not-view-operator-messages/{token}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<PlayerMessage>>(content);
            return result;
        }
        #endregion

        #region PostRequest
        //регистрация игрока по api
        public async Task<string> RegisterPlayerAsync(Player player)
        {
            var json = JsonConvert.SerializeObject(player);
            var data = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PostAsync("auth", data);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }

        //помечаем все сообщения от оператора прочитанными
        public async Task<string> PostOperatorMessage(string token)
        {
            var json = JsonConvert.SerializeObject(token);
            var data = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PostAsync("messages/set-view-operator-messages", data);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }

        //помечаем все сообщения от игрока прочитанными
        public async Task<string> PostPlayerMessage(string username)
        {
            var json = JsonConvert.SerializeObject(username);
            var data = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PostAsync("messages/set-view-player-messages", data);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
        #endregion
    }
}
