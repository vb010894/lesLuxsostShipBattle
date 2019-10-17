using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BattleSetting.ConfigStructures
{
    public sealed class ShipConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("FloorMaxCount")]
        public int FloorMaxCount
        {
            get { return (int)this["FloorMaxCount"]; }
            set { this["FloorMaxCount"] = value; }
        }

        [ConfigurationProperty("ShipFloorHealth")]
        public int ShipFloorHealth
        {
            get { return (int)this["ShipFloorHealth"]; }
            set { this["ShipFloorHealth"] = value; }
        }

        [ConfigurationProperty("canMove")]
        public bool canMove
        {
            get { return (bool)this["canMove"]; }
            set { this["canMove"] = value; }
        }

        [ConfigurationProperty("canRotate")]
        public bool canRotate
        {
            get { return (bool)this["canRotate"]; }
            set { this["canRotate"] = value; }
        }

        [ConfigurationProperty("canRotateRight")]
        public bool canRotateRight
        {
            get { return (bool)this["canRotateRight"]; }
            set { this["canRotateRight"] = value; }
        }

        [ConfigurationProperty("canRotateLeft")]
        public bool canRotateLeft
        {
            get { return (bool)this["canRotateLeft"]; }
            set { this["canRotateLeft"] = value; }
        }

        [ConfigurationProperty("canRotateTop")]
        public bool canRotateTop
        {
            get { return (bool)this["canRotateTop"]; }
            set { this["canRotateTop"] = value; }
        }

        [ConfigurationProperty("canRotateBottom")]
        public bool canRotateBottom
        {
            get { return (bool)this["canRotateBottom"]; }
            set { this["canRotateBottom"] = value; }
        }

        [ConfigurationProperty("hitValue")]
        public bool hitValue
        {
            get { return (bool)this["hitValue"]; }
            set { this["hitValue"] = value; }
        }

    }
}
