using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class users:purchasedItems
    {
        public int UserId { get; private set; }
        public string UserName { get; private set; }
        public string UserPassword { get; private set; }

        public string UserEmail { get; private set; }

        private int cartItems;
        private int overDueItems = 0;
        private int fine = 0;
        public int[] purchasedItems = new int[1000];
        public int[] dueItems = new int[1000];
        DateTime now = DateTime.Now;
        

        public users() {
            cartItems = 0;
        }
        public int[] crntItems = new int[100];
        public DateTime[] purchaseTime = new DateTime[100];
        public void AddToCart(int qty, int proId, int time)
        {
            if(cartItems<=4)
            {
                cartItems += qty;
                CartList(proId, time);
                Console.WriteLine($"Product of id:{proId} has been added to cart to be borrowed");
                
            }
            else
            {
                Console.WriteLine($"You've already requested for 4 items to be borrowed! Remove any to add new item!");
            }
        }

        public void CartList(int itemId, int time)
        {
            int[] list = new int[4];
            if (cartItems <= 4)
            {
                for(int i = 0; i < 4; i++)
                {
                    list[i] = itemId;
                }
            }
            
        }

        public void AddItems(int proId, DateTime date)
        {
            if(overDueItems>10)
            {
                for (int i = crntItems.Length; i < 100; i++)
                {
                    crntItems[i] = proId;
                    purchaseTime[i] = DateTime.Now;
                    Console.WriteLine($"Product of id:{proId} has been borrowed successfully");
                }
            }else
            {
                Console.WriteLine($"Sorry you can't borrow any more new items as there are so many due items");
            }  
            
        }

        public void ReturnItems(int proId)
        {
            
            for (int i = 0; i < crntItems.Length; i++)
            {
                if (crntItems[i] == proId)
                {
                    for (int j = i - 1; j < crntItems.Length; j++)
                    {
                        crntItems[i] = crntItems[i + 1];
                    }
                }
            }
        }    

        public void OverdueItems(DateTime purDate, int proId, int proCat)
        {
            for(int i = 0; i < crntItems.Length; i++)
            {
                for(int j = 0; j < crntItems.Length; j++)
                {
                    if (ItemsExpired(proCat, purchaseTime[j], now) == true)
                    {
                        Console.WriteLine($"{crntItems[i]}");
                        overDueItems++;
                    }

                }
            }
            
        }

        public void DueChecker()
        {
            for (int i = 0; i < dueItems.Length; i++)
                Console.WriteLine($"{dueItems[i]}");
        }

        public void Reminder(string email, int id)
        {
            Console.WriteLine($"Your borrowed product of ID: {id} has been expired. You're requested to return the product!");
        }

        public int FineChecker()
        {
            return fine;
        }
        

    }
}
