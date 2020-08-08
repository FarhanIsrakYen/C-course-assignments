using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class purchasedItems 
    {
        DateTime todaysDate = DateTime.Now;
        public bool BookExpired(DateTime purchaseDate, DateTime todaysDate)
        {
            int diff = todaysDate - purchaseDate;
            if (diff > 28)
                return true;
            else
                return false;
        }

        public bool MoviesExpired(DateTime purchaseDate, DateTime todaysDate)
        {
            int diff = todaysDate - purchaseDate;
            if (diff > 7)
                return true;
            else
                return false;
        }

        public bool GamesExpired(DateTime purchaseDate, DateTime todaysDate)
        {
            int diff = todaysDate - purchaseDate;
            if (diff > 7)
                return true;
            else
                return false;
        }
    }
}
