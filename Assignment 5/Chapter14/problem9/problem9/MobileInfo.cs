using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace problem9
{
    class MobileInfo
    {
        ArrayList mobiles = new ArrayList();
        string Model { get; set; }
        string Manufacturer { get; set; }
        int Price { get; set; }
        string Owner { get; set; }
        public MobileInfo()
        {
            this.Model = null;
            this.Manufacturer = null;
            this.Price = 0;
            this.Owner = null;
        }
        public MobileInfo(string model)
        {
            this.Model = model;
            this.Manufacturer = null;
            this.Price = 0;
            this.Owner = null;
        }
        public MobileInfo(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = 0;
            this.Owner = null;
        }
        public MobileInfo(string model, string manufacturer, int price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = null;
        }
        public MobileInfo(string model, string manufacturer, int price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }
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
