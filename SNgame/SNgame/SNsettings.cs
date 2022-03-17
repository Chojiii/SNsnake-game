using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNgame
{
    class SNsettings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }

        public static string direction;

        public SNsettings()
        {
            Width = 16;
            Height = 16;

            direction = "left";
        }



    }
}
