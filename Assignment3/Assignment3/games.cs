using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class games : purchasedItems
    {
        public int GamesId { get; private set; }
        public int GamesName { get; private set; }

        private int categoryId = 2;

        int[] gamesList;
    }
}
