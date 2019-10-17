using ShipBattle.Models;
using System.Configuration;
using System.Collections.Generic;

namespace ShipBattle.Conntrollers
{
    public class ShipController
    {

        protected int getShipMaxHealth(int countFloor)
        {
            return countFloor * int.Parse(ConfigurationManager.AppSettings["ShipFloorHealth"]);                      
        }

        protected int getFloorHealth()
        {
            return int.Parse(ConfigurationManager.AppSettings["ShipFloorHealth"]);
        }

        protected Dictionary<int, int> initStatusFloorHealth(int countFloor)
        {
            Dictionary<int, int> result = new Dictionary<int,int>();
            for (int i = 0; i < countFloor; i++)
                result.Add(i, this.getFloorHealth());

                return result;
        }

        protected bool getVectorValue(vectorSide vectorSide)
        {
            string[] vectors = ConfigurationManager.AppSettings["VecrtorShipSidesTop"].Split(',');
            foreach(string vector in vectors)
            {
                if (vector.Contains("All")) return true;
                else if (vectorSide == vectorSide.top & vector.Trim().Contains("Top")) return true;
                else if (vectorSide == vectorSide.bottom & vector.Trim().Contains("Bottom")) return true;
                else if (vectorSide == vectorSide.left & vector.Trim().Contains("Left")) return true;
                else if (vectorSide == vectorSide.leftDiagonal & vector.Trim().Contains("LeftDiagonal")) return true;
                else if (vectorSide == vectorSide.left & vector.Trim().Contains("Right")) return true;
                else if (vectorSide == vectorSide.leftDiagonal & vector.Trim().Contains("RightDiagonal")) return true;
                else return false;
            }
            return false;
        }

        protected List<int[]> getVectorShip(vectorSide side, int floorCount, int x, int y)
        { 
            if(side == vectorSide.top)
            BoardModel.Xsize
        }

        public enum vectorSide
        {
            top,
            bottom,
            right,
            rightDiagonal,
            left,
            leftDiagonal,
        }



    }
}
