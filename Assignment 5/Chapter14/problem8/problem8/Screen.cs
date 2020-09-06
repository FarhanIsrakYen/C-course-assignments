using System;
using System.Collections.Generic;
using System.Text;

namespace problem8
{
    class Screen
    {
        public string Model { get; set; }
        string Size { get; set; }
        string Colors { get; set; }
        public string ScreenInfo()
        {
            return ToString();
        }
    }
}
