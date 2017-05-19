using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {
        private int totalNumberOfItems;
        private decimal totalAmountOwed;

        public ShoppingCart()
        {
            
        }

        public int TotalNumberOfItems
        {
            get {
                return totalNumberOfItems;
            }
        }

        public decimal TotalAmountOwed
        {
            get
            {
                return totalAmountOwed;
            }
        }

        public decimal GetAveragePricePerItem()
        {
            if (TotalNumberOfItems == 0)
            {
                return 0;
            }
            else
            {
                return totalAmountOwed / totalNumberOfItems;
            }
        }

        public void AddItems(int numberOfItems, decimal pricePerItem)
        {
            totalNumberOfItems = totalNumberOfItems + numberOfItems;
            totalAmountOwed += (pricePerItem * numberOfItems);
        }

        public void Empty()
        {
            totalNumberOfItems = 0;
            totalAmountOwed = 0;
        }



       
    }
}
