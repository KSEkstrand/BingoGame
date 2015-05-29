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
        public int[] UsedBingoBalls { get; set; }
        public int[] FreeBingoBalls { get; set; }
        public ICollection<Message> Messages { get; set; }
        public string BingoWinnerUsername { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public BingoGame(BingoUser[] Users)
        {
            
            UsedBingoBalls = new int[75];
            FreeBingoBalls = new int[75];
            BingoUsers = Users;
            StartTime = DateTime.Now;
            Random _r = new Random();
            for (int i = 0; i < FreeBingoBalls.Length; i++)
            {
                FreeBingoBalls[i] = Rand(_r);
            }
            
        }

        private int Rand(Random _r)
        {            
            int num = 0;
            
            num = _r.Next(1, 75);
            if (!FreeBingoBalls.Contains(num))
            {
                return num;
            }
            else
                return Rand(_r);
        }
    }

    public class BingoGameVM
    {
        public int Id { get; set; }
        public List<string> BingoGameUsernames { get; set; }
        public int[] UsedBingoBalls { get; set; }
        public int[] FreeBingoBalls { get; set; }
    }
}