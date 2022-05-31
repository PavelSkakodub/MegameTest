# MegameTest
Для быстрой и удобной конвертации JSON в C# рекомендую https://json2csharp.com/

➤ WebAPI контроллер Auth:
◉ Получение списка всех Username игроков:
Тип запроса - GET
Путь - /api/auth
Возвращаемое значение - JSON типа List<string>
Пример - https://localhost:44395/api/auth
  
◉ Получение информации по игроку:
Тип запроса - GET
Путь - /api/auth/{token}
Возвращаемое значение - JSON типа Player(с вложенным объектом List<PlayerMessages>)
Пример - https://localhost:44395/api/auth/cwbnqkncwjb46ui5h34qioddwrv

◉ Регистрация игрока на сервере:
Тип запроса - POST
Тело запроса - объект типа Player в формате JSON
Путь - /api/auth
Возвращаемое значение - JSON типа string (результат)
Пример - https://localhost:44395/api/auth/ + Player in Body
  
  
➤ WebAPI контроллер Messages:  
◉ Получение списка всех игроков с информацией по сообщениям:
Тип запроса - GET
Путь - /api/messages/all-chats
Возвращаемое значение - JSON типа List<a> (анонимный тип с данными)
Пример - https://localhost:44395/api/messages/all-chats
  
◉ Получение списка всех сообщений игрока с оператором:
Тип запроса - GET
Путь - /api/messages/all-messages/{token}
Возвращаемое значение - JSON типа List<PlayerMessages>
Пример - https://localhost:44395/api/messages/all-messages/cwbnqkncwjb46ui5h34qioddwrv
  
◉ Получение списка сообщений, которые не прочитал оператор:
Тип запроса - GET
Путь - /api/messages/not-view-player-messages/{token}
Возвращаемое значение - JSON типа List<PlayerMessages> (где IsRead==false && MessageType==MessageType.Player)
Пример - https://localhost:44395/api/messages/not-view-player-messages/cwbnqkncwjb46ui5h34qioddwrv
  
◉ Получение списка сообщений, которые не прочитал игрок:
Тип запроса - GET
Путь - /api/messages/not-view-operator-messages/{token} 
Возвращаемое значение - JSON типа List<PlayerMessages> (где IsRead==false && MessageType==MessageType.Operator) 
Пример - https://localhost:44395/api/messages/not-view-operator-messages/cwbnqkncwjb46ui5h34qioddwrv
  
◉ Пометка всех сообщений от оператора прочитанными (для Unity):
Тип запроса - POST
Тело запроса - объект типа string в формате JSON (токен)
Путь - /api/messages/set-view-operator-messages
Возвращаемое значение - JSON типа bool (результат)
Пример - https://localhost:44395/api/messages/set-view-operator-messages + token in Body
  
◉ Пометка всех сообщений от игрока прочитанными (для сервера):
Тип запроса - POST
Тело запроса - объект типа string в формате JSON (username)
Путь - /api/messages/set-view-player-messages
Возвращаемое значение - JSON типа bool (результат)
Пример - https://localhost:44395/api/messages/set-view-player-messages + username in Body
