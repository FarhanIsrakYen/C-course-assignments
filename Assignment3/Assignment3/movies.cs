using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class movies : purchasedItems
    {
        public int MovieId { get; private set; }
        public int MovieName { get; private set; }

        private int categoryId = 3;

        int[] moviesList;
    }
}
