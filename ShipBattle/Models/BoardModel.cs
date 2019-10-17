using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ShipBattle.Models
{
    public class BoardModel
    {
        public static readonly int Xsize;
        public static readonly int Ysize;

        static BoardModel()
        {
        
            Xsize = int.Parse(ConfigurationManager.AppSettings["BoardWidth"]);
            Ysize = int.Parse(ConfigurationManager.AppSettings["BoardHeight"]);
        }

        public static void printBoard(List<int[]> ships) 
        {
           // IList breakPoint = new int[][];
            Console.Write("   ");
            for (int i = 0; i < Ysize; i++) Console.Write(i + " ");

            Console.WriteLine();

            for (int i = 0; i < Ysize; i++)
            {
                Console.Write(i + " ");

                if(i < 10) Console.Write(" ");

                for (int j = 0; j < Xsize; j++)
                {

                    string cellMask = "x";
                    try 
                    {
                        int[] res = ships.Single(s => (s[0] == i & s[1] == j));
                        cellMask = (res != null) ? "S" : "x";
                    }
                    catch (Exception ex)
                        {
                            // do nothing
                        }

                    Console.Write(cellMask);
                    cellMask = null;
                }
                Console.WriteLine();
            }

        }
    }
}
