using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace BookStoreExercism
{
    public class BookStore
    {
        public double CalculateTotal(int[] basket)
        {
            if (CheckIfBasketHasDistinctBooksOrIsEmpty(basket))
            {
                return basket.Length * 8 * 1.00;
            }
            else if (basket.Length == 4)
            {
                return basket.Length * CostOfBook() * Discount(basket.Length);
            }
            else if (basket.Length == 3)
            {
                return basket.Length * CostOfBook() * Discount(basket.Length);
            }
            else
            {
                return basket.Length * CostOfBook() * Discount(basket.Length);
            }
            
        }

        private double Discount(int numberOfBooks)
        {
            if (numberOfBooks == 4)
            {
                return .80;
            }

            if (numberOfBooks == 3)
            {
                return .90;
            }

            return 0.95;
        }


        private int CostOfBook()
        {
            return 8;
        } 

        private bool CheckIfBasketHasDistinctBooksOrIsEmpty(int[] basket)
        {
            return basket.ToList().Distinct().Count() == 1 || basket.Length == 0;
        }
    }
}
