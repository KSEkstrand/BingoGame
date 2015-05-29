using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngSignalR2.DAL.Models
{
    public class BingoGame
    {
        public int Id { get; set; }
        public ICollection<BingoUser> BingoUsers { get; set; }
        public ICollection<BingoBall> UsedBingoBalls { get; set; }
        public ICollection<BingoBall> FreeBingoBalls { get; set; }
        public ICollection<Message> Messages { get; set; }
        public string BingoWinnerUsername { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        //public BingoGame(BingoUser[] Users)
        //{
        //    BingoUsers = Users;
        //}
    }

    public class BingoGameVM
    {
        public int Id { get; set; }
        public List<string> BingoGameUsernames { get; set; }
        public IEnumerable<int> UsedBingoBalls { get; set; }
        public IEnumerable<int> FreeBingoBalls { get; set; }
    }
}