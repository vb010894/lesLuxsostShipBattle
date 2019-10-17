using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleSetting;

namespace BattleSetting.Configs
{
    public class PlayerSettings
    {
        /// <summary>
        /// Список типов игрока
        /// </summary>
        public enum gamerType
        {
            Human = 0,
            Bot = 1
        }

        /// <summary>
        /// Может ли игрок сдаться
        /// </summary>
        public bool CanGiveUp { get; set; }

        /// <summary>
        /// Реализация типа игрока
        /// </summary>
        public gamerType PalyerType { get; set; }

        /// <summary>
        /// Максимальное количество кораблей в флоте
        /// </summary>
        public int MaxValueInFleet { get; set; }

    }
}
