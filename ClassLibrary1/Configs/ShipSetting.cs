using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleSetting.Enums;

// *********************************************************************************
// Author:	Vladimir Zinovev
// Email:	aleksiev_vov@mail.ru
// Date: 	10.17.2019
// Project:	BattleSetting.Configs
// *********************************************************************************
namespace BattleSetting.Configs
{
    /// <summary>
    /// настройки одного корабля
    /// </summary>
    public class ShipSetting
    {
        /// <summary>
        /// Сторона коробля
        /// </summary>
        public BuildEnums.SideVectors vector { get; set; }

        /// <summary>
        /// Количество палуб на корабле
        /// </summary>
        public int floorCount { get; set; }

    }
    
    /// <summary>
    /// Общие настройки кораблей
    /// </summary>
    public class ShipsSetting
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

}
