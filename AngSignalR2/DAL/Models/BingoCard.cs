using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngSignalR2.DAL.Models
{
    //not a db entry
    public class BingoCard
    {
        public int[] RowB { get; private set; }
        public int[] RowI { get; private set; }
        public int[] RowN { get; private set; }
        public int[] RowG { get; private set; }
        public int[] RowO { get; private set; }
        public string BingoUsername { get; set; }

        private static Dictionary<string, int[]> MaxMin = new Dictionary<string, int[]>{
            {"B", new int[]{1,15}},
            {"I", new int[]{16,30}},
            {"N", new int[]{31,45}},
            {"G", new int[]{41,60}},
            {"O", new int[]{61,75}}
        };

        public string Username { get; set; }

        public BingoCard(string Id)
        {
            BingoUsername = Id;

            RowB = CreateRow(new int[5]);
            RowI = CreateRow(new int[5]);
            RowN = CreateRow(new int[5]);
            RowN[2] = 0; //Free in center of board is 0 in this case
            RowG = CreateRow(new int[5]);
            RowO = CreateRow(new int[5]);     
        }

        private static int[] CreateRow(int[] tempRow)
        {
            Random r = new Random();
            int num;
            for (int i = 0; i < tempRow.Length; i++)
            {
                num = Draw(tempRow, r, MaxMin.ElementAt(i));
                tempRow[i] = num;
            }
            return tempRow;
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