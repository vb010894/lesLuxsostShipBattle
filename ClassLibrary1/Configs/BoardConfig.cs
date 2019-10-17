using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSetting.Configs
{
    public class BoardConfig
    {
        /// <summary>
        /// Высота доски
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Ширина доски
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Маска пустой ячейки в доске
        /// </summary>
        public string EmptyMask { get; set; }

        /// <summary>
        /// Маска ячейки, занятой кораблем
        /// </summary>
        public string ShipMAsk { get; set; }
    }
}
