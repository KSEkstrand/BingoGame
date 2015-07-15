using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Omu.ValueInjecter;

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
        public string UserName { get; set; }

    }

    public class MessageVM
    {
        public string UserName { get; set; }
        public int BingoGameId { get; set; }
        public string MessageText { get; set; }
        public string TimeSent { get; set; }

        private MessageVM() { }

        MessageVM(Message m)
        {
            MessageBM vm = new MessageBM();
            vm.InjectFrom(m);
        }
    }

    public class MessageBM
    {
        public string UserName { get; set; }
        public int BingoGameId { get; set; }
        public string MessageText { get; set; }
        public string TimeSent { get; set; }
    }

    
}