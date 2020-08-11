using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class itemMerger
    {
        int[] itemListId = new int[1000];
        int[] itemListCat = new int[1000];
        object[] itemListName = new object[1000];
        

        public string GetCategoryName(int itemId)
        {
            int identifier=0;
            for(int i = 0; i <= itemListId.Length; i++)
            {
                
                    if (itemListId[i] == itemId)
                        identifier = itemListCat[i];
                
            }
            if (identifier == 1)
                return "Books";
            else if (identifier == 2)
                return "Games";
            else
                return "Movies";

        }
    }
}
