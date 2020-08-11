using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class secretary
    {
        public int SecId { get; private set; }
        public string SecName { get; private set; }
        public string SecPassword { get; private set; }

        int[] itemListId = new int[1000];
        int[] itemListCat = new int[1000];
        string[] itemListName = new string[1000];

        

        public void addItem(int id, int category, string name)
        {
            for (int i = 0; i < 1000; i++)
            {
                itemListId[i] = id;
                itemListCat[i] = category;
                itemListName[i] = name;
            }
        }
    }
}
