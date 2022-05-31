//регистрация обработчика события для всей страницы (событие загрузки контента)
document.addEventListener("DOMContentLoaded", () => {

    //создаём подключение с логированием и переподключением через время
    const connection = new signalR.HubConnectionBuilder()
        .withUrl("/playerHub")
        .configureLogging(signalR.LogLevel.Information)
        .withAutomaticReconnect([0, 500, 5000, 30000])
        .build();

    //обработка приёма сообщения
    connection.on("ServerReceiveMessage", (username, message) => {        
        createMessage("you", username, message);
    });

    //отправка всем юзерам
    document.getElementById("sendToUser").addEventListener("click", sendMessage);

    //функция отправки сообщения юзеру
    async function sendMessage() {
        //получаем div класса активного чата (т.е с кем переписываемся)
        var element = document.getElementsByClassName("chat active-chat");
        //извлекаем значение из input в котором название текущего чата
        const username = element[0].querySelector('input[name="username"]').value;
        //получаем сообщение по айди
        const message = document.getElementById("messageInput").value;
        //проверка на пустое сообщение
        if (message == null || message == '') return;
        //перед отправкой рисуем сообщение у себя
        createMessage("me", username, message);
        //отправляем сообщение на сервер
        connection.invoke("SendToUnity", username, message).catch(function (err) {
            return console.error(err.toString());
        });
        //очищаем сообщение
        document.getElementById("messageInput").value = '';
    }

    //рисование сообщения
    function createMessage(mesType, username, message) {
        //получаем текущее время
        var date = new Date();
        var hours = date.getHours();
        var minute = date.getMinutes();
        var seconds = date.getSeconds();
        //получаем контейнер сообщений по id
        var div = document.getElementById(username);
        //html-код сообщения с переданными значениями
        var messageTemplate = `<div class="bubble ${mesType}">${message}   |${hours}:${minute}:${seconds}|</div>`;
        //вставляем в конец html сообщение
        div.insertAdjacentHTML("beforeend", messageTemplate);
        //передвигаем скроллер
        const getScrollContainer = document.querySelector('.chat-conversation-box');
        getScrollContainer.scrollTop = getScrollContainer.scrollHeight;
    }

    //функция старта подключения
    async function start() {
        try {
            await connection.start();
        }
        catch (err) //записываем ошибки
        {
            console.log(err);
        }
    }

    //обработка закрытия подключения
    connection.onclose(error => {
        //добавляем в консоль состояние отключения 
        console.assert(connection.state === signalR.HubConnectionState.Disconnected);
        //отключаем ввод сообщения
        document.getElementById("messageInput").disabled = true;
        //пишем что нужно перезагрузить страницу
        console.log(`Connection closed due to error "${error}". Try refreshing this page to restart the connection.`);
    });

    //старт подключения
    start();
});
