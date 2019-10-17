using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShipBattle.Conntrollers;

namespace ShipBattle.Models
{
    public interface PlayerModel
    {


        void addToFleet(ShipModel ship = null);

        bool IsHit(ShipModel shop, int x = 0, int y = 0);


    }
}
