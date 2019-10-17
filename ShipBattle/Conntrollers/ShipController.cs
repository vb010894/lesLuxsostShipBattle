using ShipBattle.Models;
using System.Configuration;
using System.Linq;
using System.Collections.Generic;
using System;

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
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < countFloor; i++)
                result.Add(i, this.getFloorHealth());

            return result;
        }

        protected bool getVectorValue(vectorSide vectorSide)
        {
            string[] vectors = ConfigurationManager.AppSettings["VecrtorShipSides"].Split(',');
            foreach (string vector in vectors)
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

        protected List<int[]> getVectorShip(vectorSide side, int floorCount, int xStart, int yStart)
        {
            List<int[]> result = new List<int[]>();
            if (side == vectorSide.top)
            {
                for (int i = yStart; i >= 0; i--)
                {
                    int[] point = {i, xStart};
       
                    result.Add(point);
                }
            }
            if (side == vectorSide.bottom)
            {
                for (int i = yStart; i < floorCount; i++)
                {
                    int[] point = { i, xStart };

                    result.Add(point);
                }
            }
            if (side == vectorSide.left)
            {
                for (int i = xStart; i >= 0; i--)
                {
                    int[] point = { yStart, i };

                    result.Add(point);
                }
            }

            if (side == vectorSide.right)
            {
                for (int i = xStart; i < floorCount; i++)
                {
                    int[] point = { yStart, i };

                    result.Add(point);
                }
            }

            if (side == vectorSide.leftDiagonal)
            {
                for (int i = yStart; i >= 0; i--)
                {
                    for (int j = xStart; j >= 0; j--)
                    {
                        int[] point = { i, j };

                        result.Add(point);
                    }
                }

            }

            if (side == vectorSide.leftDiagonal)
            {
                for (int i = yStart; i < floorCount; i++)
                {
                    for (int j = xStart; j < floorCount; j++)
                    {
                        int[] point = { i, j };

                        result.Add(point);
                    }
                }

            }
            return result;
        }

        public bool isHit(int x, int y, ShipModel ship)
        {

            bool result = false;

                try
                {
                    int[] res = ship.vectorShip.Single(s => (s[0] == y & s[1] == x));
                    result = (res != null) ? true: false;
                }
                catch (Exception  ex)
                {
                    // do nothing
                }

            if (result)
            {
                
            }
            return result;

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
