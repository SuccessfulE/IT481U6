using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT481U6
{
    class Customer
    {
        //Variable set
        int NumberOfItems;

        public Customer()
        {
            NumberOfItems = 6;
        }

        public Customer(int items)
        {
            int ClothingItems = items;
            if (ClothingItems == 0)
            {
                NumberOfItems = GetRandomNumber(1, 20);

            }
            else
            {
                NumberOfItems = ClothingItems;
            }
        }

        //Return the number of items
        public int getNumberOfItems()
        {
            return NumberOfItems;
        }

        //Random number methods
        private static readonly Random getrandom = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            lock(getrandom)
            {
                return getrandom.Next(min, max);
            }
        }
    }
}
