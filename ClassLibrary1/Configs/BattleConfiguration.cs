using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSetting.Configs
{
    /// <summary>
    /// Настройки битвы
    /// </summary>
    public class BattleConfiguration
    {
        public enum varTypes
        {
            Fixed = 0,
            Variable = 1,
        }

        public int GamePartCount { get; set; }


    }
}
