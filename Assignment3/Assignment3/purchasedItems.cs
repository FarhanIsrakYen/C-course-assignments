using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class purchasedItems : itemMerger 
    {
        DateTime todaysDate = DateTime.Now;
        int[] bookedItemList = new int[1000];
        

        public bool ItemsExpired(int id, DateTime purchaseDate, DateTime todaysDate)
        {
            int diff = todaysDate - purchaseDate;
            bool status = false;
            if(id == 1)
            {
                if (diff > 28)
                    status = true;
            }else
            {
                if (diff > 7)
                    status = true;
            }
            return status;
        }
    }
}
