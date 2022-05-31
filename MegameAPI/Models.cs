using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegameAPI
{
    public class Player
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public List<PlayerMessage> PlayerMessages { get; set; }
    }

    public class PlayerMessage
    {
        public int Id { get; set; }
        public MessageType MessageType { get; set; }
        public string Username { get; set; }
        public string Body { get; set; }
        public DateTime Time { get; set; }
        public bool IsRead { get; set; }

        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }

    //тип отправителя сообщения
    public enum MessageType
    {
        Operator,
        Player
    }

    //чат с инфой по юзеру
    public class AllChats
    {
        public string player { get; set; }
        public int messagesCount { get; set; }
        public int playerMessages { get; set; }
        public int messagesNotView { get; set; }
        public DateTime lastMessage { get; set; }
    }

}
