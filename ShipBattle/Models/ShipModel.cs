using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShipBattle.Conntrollers;

namespace ShipBattle.Models
{
    public class ShipModel : ShipController
    {
        public readonly int startX;
        public readonly int startY;
        public readonly int floorCount;
        public readonly int floorHealth;
        public readonly int shipMaxHealth;
        public readonly vectorSide currentVector;
        public readonly List<int[]> vectorShip = new List<int[]>();
        private bool canLeftVector;
        private bool canLeftDiagonalVector;
        private bool canRightVector;
        private bool canRightDiagonaVector;
        private bool canTopVector;
        private bool canBottomVector;
        

        public readonly Dictionary<int, int> statusFloorHealth = new Dictionary<int, int>();

        public ShipModel(int x, int y, int floorCount, vectorSide vector)
        {
            this.startX = x;
            this.startY = y;
            this.currentVector = vector;
            this.floorHealth = this.getFloorHealth();
            this.shipMaxHealth = this.getShipMaxHealth(floorCount);
            this.statusFloorHealth = this.initStatusFloorHealth(floorCount);
            this.canBottomVector = this.getVectorValue(vectorSide.bottom);
            this.canTopVector = this.getVectorValue(vectorSide.top);
            this.canLeftVector = this.getVectorValue(vectorSide.left);
            this.canLeftDiagonalVector = this.getVectorValue(vectorSide.leftDiagonal);
            this.canRightDiagonaVector = this.getVectorValue(vectorSide.rightDiagonal);
            this.canRightVector = this.getVectorValue(vectorSide.right);
        }

               
    }
}
