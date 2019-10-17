using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSetting.Configs
{
    public class ShipSetting
    {
        /// <summary>
        /// Максимальное количество палуб в корабле
        /// </summary>
        public int FloorMaxCount { get; set; }

        /// <summary>
        /// Количество здоровья палубы
        /// </summary>
        public int ShipFloorHealth { get; set; }

        /// <summary>
        /// Может ли двигаться
        /// </summary>
        public bool canMove { get; set; }

        /// <summary>
        /// Может ли менять положение
        /// </summary>
        public bool canRotate { get; set; }

        /// <summary>
        /// Может ли корабль разворачиваться в правую сторону
        /// </summary>
        public bool canRotateRight { get; set; }

        /// <summary>
        /// Может ли корабль разворачиваться на левую сторону
        /// </summary>
        public bool canRotateLeft { get; set; }

        /// <summary>
        /// Может ли корабль разворачиваться прямо
        /// </summary>
        public bool canRotateTop { get; set; }

        /// <summary>
        /// VМожет ли корабль разворачиваться назад
        /// </summary>
        public bool canRotateBottom { get; set; }

        /// <summary>
        /// Процент хита, отнимающего здоровье
        /// </summary>
        public int hitValue { get; set; }

    }

    public class ShipsSetting
    {
      //  public vectorSide
        
    }

}
