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

    public async void GetInfo() //��������� ���� �� �������� ������
    {
        using MegameHttpClient client = new MegameHttpClient();  
        Player player = await client.GetPlayerAsync(token);
        Debug.ClearDeveloperConsole();
        Debug.Log($"|Username: {player.Username} |Token: {player.Token} |Messages: {player.PlayerMessages.Count}");
    }

    public async void GetUsernameListAsync() //��������� ������ ���� �������
    {
        using MegameHttpClient client = new MegameHttpClient();
        var playersName = await client.GetUsernameListAsync();
        Debug.ClearDeveloperConsole();
        for (int i = 0; i < playersName.Count; i++) Debug.Log($"Player {i + 1}, username: {playersName[i]}");
    }

    public async void GetAllChats() //��������� ���� �� ���� �����
    {
        using MegameHttpClient client = new MegameHttpClient();
        var chats = await client.GetAllChats();
        Debug.ClearDeveloperConsole();
        for (int i = 0; i < chats.Count; i++)
        {
            Debug.Log($"Player: {chats[i].player} |AllMessages: {chats[i].messagesCount} |PlayerMessages: {chats[i].playerMessages} |NotViewMessages: {chats[i].messagesNotView} |LastMessage: {chats[i].lastMessage:G}");
        }
    }

    public async void GetAllMessages() //��������� ���� ���������
    {
        using MegameHttpClient client = new MegameHttpClient();
        Debug.ClearDeveloperConsole();
        //�������� ������ ���� ��������� (���� ���)
        var messages = await client.GetAllMessages(token);
        //����� ��������� � ����������� �� ���� ���
        foreach (var m in messages)
        {
            if (m.MessageType == MessageType.Operator) Debug.Log($"Operator ({m.Username}): {m.Body} |IsRead: {m.IsRead}|{m.Time:G}|");
            else Debug.Log($"Me: {m.Body} |IsRead: {m.IsRead}|{m.Time:G}|");
        }
    }

    public async void GetNotViewPlayerMessages() //�������� ��� ��������� ������� �� �������� �������� 
    {
        using MegameHttpClient client = new MegameHttpClient();
        Debug.ClearDeveloperConsole();
        //�������� ������ ��������� �� ������� �������� �� �������
        var messages = await client.GetNotViewPlayerMessages(token);
        //������� ��������� � �������
        foreach (var m in messages) Debug.Log($"Me: {m.Body} |IsRead: {m.IsRead}| {m.Time:G}");
    }

    public async void GetNotViewOperatorMessages() //�������� ��� ��������� ������� �� �������� ����� 
    {
        using MegameHttpClient client = new MegameHttpClient();
        Debug.ClearDeveloperConsole();
        //�������� ������ ��������� �� ������� �������� �� �������
        var messages = await client.GetNotViewOperatorMessages(token);
        //������� ��������� � �������
        foreach (var m in messages) Debug.Log($"Operator ({m.Username}): {m.Body} |IsRead: {m.IsRead}| {m.Time:G}");
    }
}
