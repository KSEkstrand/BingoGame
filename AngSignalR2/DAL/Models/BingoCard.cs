using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngSignalR2.DAL.Models
{
    public class BingoCard
    {
        public int[] RowB { get; set; }
        public int[] RowI { get; set; }
        public int[] RowN { get; set; }
        public int[] RowG { get; set; }
        public int[] RowO { get; set; }

        private static Dictionary<string, int[]> MaxMin = new Dictionary<string, int[]>{
            {"B", new int[]{1,15}},
            {"I", new int[]{16,30}},
            {"N", new int[]{31,45}},
            {"G", new int[]{41,60}},
            {"O", new int[]{61,75}}
        };

        public string Username { get; set; }

        public BingoCard()
        {
            int[] tempRow = new int[5];
            int num;
            Random r = new Random();

            for (int i = 0; i < tempRow.Length; i++)
            {
                num = Draw(tempRow, r, MaxMin.ElementAt(i));
            }
            
        }

        private static int Draw(int[] tempRow, Random r, KeyValuePair<string,int[]> lims)
        {
            int num;
            num = r.Next(lims.Value[0], lims.Value[1]);
            if (tempRow.Contains(num))
            {
                num = r.Next();
                Draw(tempRow, r, lims);
            }
            return num;
        }
    }
}