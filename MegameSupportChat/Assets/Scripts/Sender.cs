using System;
using UnityEngine.UI;
using UnityEngine;
using BestHTTP.SignalRCore;
using BestHTTP.SignalRCore.Encoders;
using MegameAPI;

public class Sender : MonoBehaviour
{
    public InputField Username; //поле ввода никнейма
    public InputField Message; //поле ввода сообщения
    private HubConnection Hub; //концентратор
    private string token;

    public async void Click()
    {
        //отправка на сервер сообщения
        if (Message.text.Trim().Length != 0)
        {
            //пишем в консоль сообщение (пока непрочитанное)
            Debug.Log($"Me: {Message.text} |IsRead: false|{DateTime.Now:G}|");
            //отправляем сообщение
            await Hub.SendAsync("SendFromUnity", Username.text.ToString(), Message.text.ToString());
            Message.text = "";
            //помечаем сообщения от оператора прочитанными (т.к мы отправили ответ => всё прочли)
            using MegameHttpClient client = new MegameHttpClient();
            await client.PostOperatorMessage(token);
        }
    }

    void Start() //инициализация хаба
    {
        token = SystemInfo.deviceUniqueIdentifier;

        //настройки подключения
        HubOptions options = new HubOptions()
        {
            SkipNegotiation = false,
            PreferedTransport = TransportTypes.WebSocket,
            PingInterval = TimeSpan.FromSeconds(60),
            PingTimeoutInterval = TimeSpan.FromSeconds(120),
            ConnectTimeout = TimeSpan.FromSeconds(120)
        };

        //инициализация подключения
        Hub = new HubConnection(
            new Uri("https://localhost:44395/playerHub"),
            new JsonProtocol(new LitJsonEncoder()));
        //настройка по умолчанию для повторного подключения
        Hub.ReconnectPolicy = new DefaultRetryPolicy();

        //подключение к хабу
        Hub.StartConnect();
        Hub.OnReconnected += Hub_OnReconnected;
        //задаём метод обработчик сообщений с сервера
        Hub.On("UnityReceiveMessage", (string operatorName, string message) =>
        {
            //пишем сообщение от оператора
            Debug.Log($"Operator ({operatorName}): {message} |IsRead: true|{DateTime.Now:G}|");
        });
    }

    private void Hub_OnReconnected(HubConnection obj)
    {
        Hub.StartConnect();
    }
}
