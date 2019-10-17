using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using ShipBattle.Conntrollers;

namespace ShipBattle.Models
{
    public class HumanModel : PlayerController, PlayerModel
    {
        private List<int[]> fleet = new List<int[]>();
        public readonly string name;
        public readonly bool canPlayGame;

        public HumanModel(string name)
        {
            this.name = name;
            this.canPlayGame = true;
        }

        public void addToFleet(ShipModel ship = null)
        {
            this.fleet.AddRange(ship.vectorShip);
        }
    }
}
