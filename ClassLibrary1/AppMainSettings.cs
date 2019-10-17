using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleSetting.Configs;


namespace BattleSetting
{
    public sealed  class AppMainSettings
    {
        public AppMainSettings()
        {
            battleConfiguration = new BattleConfiguration();
            playerSettings = new PlayerSettings();
            shipSetting = new ShipSetting();
            boardConfig = new BoardConfig();

        }

        /// <summary>
        /// Настройки битвы
        /// </summary>
        public BattleConfiguration battleConfiguration { get; set; }

        /// <summary>
        /// Настройки пользователя
        /// </summary>
        public PlayerSettings playerSettings{ get; set; }

        /// <summary>
        /// Настройки корабля
        /// </summary>
        public ShipSetting shipSetting { get; set; }

        /// <summary>
        /// Настройка доски
        /// </summary>
        public BoardConfig boardConfig { get; set; }
    }
}
