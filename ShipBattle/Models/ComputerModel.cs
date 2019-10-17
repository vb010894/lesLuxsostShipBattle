using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShipBattle.Conntrollers;
using System.Configuration;

namespace ShipBattle.Models
{
    public class ComputerModel : PlayerController, PlayerModel
    {

        private List<int[]> fleet = new List<int[]>();
        public readonly string name;
        public readonly bool canPlayGame;

        public ComputerModel()
        {
            this.name = "Computer";
            this.canPlayGame = true;
        }

        public void addToFleet(ShipModel ship = null)
        {
            int shipCount = int.Parse(ConfigurationManager.AppSettings["ShipCount"]);
            Random rand = new Random();
            for (int i = 0; i < shipCount; i++)
            {
                var sideValues = Enum.GetValues(typeof(ShipModel.vectorSide));

                ShipModel model = new ShipModel(rand.Next(0, BoardModel.Xsize), rand.Next(0, BoardModel.Ysize), shipCount, (ShipModel.vectorSide)sideValues.GetValue(rand.Next(sideValues.Length)));
                this.fleet.AddRange(model.vectorShip);
            }
        }
    }
}
