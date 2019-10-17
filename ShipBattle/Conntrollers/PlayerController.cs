using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShipBattle.Models;
using System.Configuration;

namespace ShipBattle.Conntrollers
{
    public class PlayerController
    {

        public bool IsHit(ShipModel ship, int x = 0, int y = 0)
        {
            return ship.isHit(x, y, ship.vectorShip);
        }

    }
}
