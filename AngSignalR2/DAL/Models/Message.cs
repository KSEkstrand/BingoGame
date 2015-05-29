using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngSignalR2.DAL.Models
{
    //Db Entry to hold messages
    public class Message
    {
        public int Id { get; set; }
        public BingoUser BingoUser { get; set; }
        public string BingoUserId { get; set; }
        public BingoGame BingoGame { get; set; }
        public int BingoGameId { get; set; }
        public string MessageText { get; set; }
        public string TimeSent { get; set; }
    }

    public class MessageVM
    {
        public string UserName { get; set; }
        public int BingoGameId { get; set; }
        public string MessageText { get; set; }
        public string TimeSent { get; set; }
    }

    public class MessageBM
    {
        public string UserName { get; set; }
        public int BingoGameId { get; set; }
        public string MessageText { get; set; }
        public string TimeSent { get; set; }
    }
}