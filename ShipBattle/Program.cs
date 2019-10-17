using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShipBattle.Models;

namespace ShipBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int[]> ships = new List<int[]>();
            ships.Add( new int[2]{0, 2});
            ships.Add( new int[2]{0, 0});

                 BoardModel.printBoard(ships);
                Console.ReadKey();
        }
    }
}
