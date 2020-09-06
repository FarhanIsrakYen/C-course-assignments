using System;
using System.Collections.Generic;
using System.Text;

namespace problem10
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

        public static void ScreenInfoNokiaN95()
        {
            string Size = "2.6 inches";
            string Color = "black";
        }
    }
}
