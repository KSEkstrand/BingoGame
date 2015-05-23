using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngSignalR2.DAL.Models
{
    //Not a DB entry
    public class RankingBoard
    {
        public IEnumerable<string> BingoUserNames { get; set; }
        public IEnumerable<int> Scores { get; set; }
        public IEnumerable<DateTime> GameTimes { get; set; }
    }
}