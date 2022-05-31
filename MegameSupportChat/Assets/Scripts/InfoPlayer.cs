using System.Collections;
using System.Collections.Generic;
using MegameAPI;
using UnityEngine;

public class InfoPlayer : MonoBehaviour
{
    private string token;

    public void Start()
    {
        token = SystemInfo.deviceUniqueIdentifier;
    }

    public async void GetInfo() //получение инфы по текущему игроку
    {
        using MegameHttpClient client = new MegameHttpClient();  
        Player player = await client.GetPlayerAsync(token);
        Debug.ClearDeveloperConsole();
        Debug.Log($"|Username: {player.Username} |Token: {player.Token} |Messages: {player.PlayerMessages.Count}");
    }

    public async void GetUsernameListAsync() //получение списка всех игроков
    {
        using MegameHttpClient client = new MegameHttpClient();
        var playersName = await client.GetUsernameListAsync();
        Debug.ClearDeveloperConsole();
        for (int i = 0; i < playersName.Count; i++) Debug.Log($"Player {i + 1}, username: {playersName[i]}");
    }

    public async void GetAllChats() //получение инфы по всем чатам
    {
        using MegameHttpClient client = new MegameHttpClient();
        var chats = await client.GetAllChats();
        Debug.ClearDeveloperConsole();
        for (int i = 0; i < chats.Count; i++)
        {
            Debug.Log($"Player: {chats[i].player} |AllMessages: {chats[i].messagesCount} |PlayerMessages: {chats[i].playerMessages} |NotViewMessages: {chats[i].messagesNotView} |LastMessage: {chats[i].lastMessage:G}");
        }
    }

    public async void GetAllMessages() //получение всей переписки
    {
        using MegameHttpClient client = new MegameHttpClient();
        Debug.ClearDeveloperConsole();
        //получаем список всех сообщений (весь чат)
        var messages = await client.GetAllMessages(token);
        //вывод сообщений в зависимости от кого оно
        foreach (var m in messages)
        {
            if (m.MessageType == MessageType.Operator) Debug.Log($"Operator ({m.Username}): {m.Body} |IsRead: {m.IsRead}|{m.Time:G}|");
            else Debug.Log($"Me: {m.Body} |IsRead: {m.IsRead}|{m.Time:G}|");
        }
    }

    public async void GetNotViewPlayerMessages() //получаем мои сообщения которые не прочитал оператор 
    {
        using MegameHttpClient client = new MegameHttpClient();
        Debug.ClearDeveloperConsole();
        //получаем список сообщений на которые оператор не ответил
        var messages = await client.GetNotViewPlayerMessages(token);
        //выводим сообщения в консоль
        foreach (var m in messages) Debug.Log($"Me: {m.Body} |IsRead: {m.IsRead}| {m.Time:G}");
    }

    public async void GetNotViewOperatorMessages() //получаем мои сообщения которые не прочитал игрок 
    {
        using MegameHttpClient client = new MegameHttpClient();
        Debug.ClearDeveloperConsole();
        //получаем список сообщений на которые оператор не ответил
        var messages = await client.GetNotViewOperatorMessages(token);
        //выводим сообщения в консоль
        foreach (var m in messages) Debug.Log($"Operator ({m.Username}): {m.Body} |IsRead: {m.IsRead}| {m.Time:G}");
    }
}
