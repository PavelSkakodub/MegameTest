using System;
using UnityEngine.UI;
using UnityEngine;
using BestHTTP.SignalRCore;
using BestHTTP.SignalRCore.Encoders;
using MegameAPI;

public class Sender : MonoBehaviour
{
    public InputField Username; //���� ����� ��������
    public InputField Message; //���� ����� ���������
    private HubConnection Hub; //������������
    private string token;

    public async void Click()
    {
        //�������� �� ������ ���������
        if (Message.text.Trim().Length != 0)
        {
            //����� � ������� ��������� (���� �������������)
            Debug.Log($"Me: {Message.text} |IsRead: false|{DateTime.Now:G}|");
            //���������� ���������
            await Hub.SendAsync("SendFromUnity", Username.text.ToString(), Message.text.ToString());
            Message.text = "";
            //�������� ��������� �� ��������� ������������ (�.� �� ��������� ����� => �� ������)
            using MegameHttpClient client = new MegameHttpClient();
            await client.PostOperatorMessage(token);
        }
    }

    void Start() //������������� ����
    {
        token = SystemInfo.deviceUniqueIdentifier;

        //��������� �����������
        HubOptions options = new HubOptions()
        {
            SkipNegotiation = false,
            PreferedTransport = TransportTypes.WebSocket,
            PingInterval = TimeSpan.FromSeconds(60),
            PingTimeoutInterval = TimeSpan.FromSeconds(120),
            ConnectTimeout = TimeSpan.FromSeconds(120)
        };

        //������������� �����������
        Hub = new HubConnection(
            new Uri("https://localhost:44395/playerHub"),
            new JsonProtocol(new LitJsonEncoder()));
        //��������� �� ��������� ��� ���������� �����������
        Hub.ReconnectPolicy = new DefaultRetryPolicy();

        //����������� � ����
        Hub.StartConnect();
        Hub.OnReconnected += Hub_OnReconnected;
        //����� ����� ���������� ��������� � �������
        Hub.On("UnityReceiveMessage", (string operatorName, string message) =>
        {
            //����� ��������� �� ���������
            Debug.Log($"Operator ({operatorName}): {message} |IsRead: true|{DateTime.Now:G}|");
        });
    }

    private void Hub_OnReconnected(HubConnection obj)
    {
        Hub.StartConnect();
    }
}
