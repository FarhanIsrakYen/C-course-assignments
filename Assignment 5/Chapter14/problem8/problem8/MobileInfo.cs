using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace problem8
{
    class MobileInfo
    {
        ArrayList mobiles = new ArrayList();
        string Model { get; set; }
        string Manufacturer { get; set; }
        string Price { get; set; }
        string Owner { get; set; }
        Battery bat = new Battery();
        Screen sc = new Screen();
        string BatteryFeat(string phoneModel)
        {
            if (phoneModel.Equals(bat.Model) && phoneModel.Equals(sc.Model))
            {
                return bat.BatteryInfo();
            }
            else
                return "This model doesn't exist";
        }
    }
}
