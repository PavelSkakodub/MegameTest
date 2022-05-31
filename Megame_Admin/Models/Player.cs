using System;
using System.Collections.Generic;

namespace Megame_Admin.Models
{
    public class Player
    {
        public int Id { get; set; }
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
}
