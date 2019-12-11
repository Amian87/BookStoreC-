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
            return basket.Length * CostOfBook() * Discount(NumberOfDistinctBooks(basket));

            //if (CheckIfBasketHasDistinctBooksOrIsEmpty(basket))
            //{
            //    return basket.Length * CostOfBook() * Discount(NumberOfDistinctBooks(basket));
            //}
            //if (basket.Length == 5)
            //{
            //    return basket.Length * CostOfBook() * Discount(NumberOfDistinctBooks(basket));
            //}
            //if (basket.Length == 4)
            //{
            //    return basket.Length * CostOfBook() * Discount(NumberOfDistinctBooks(basket));
            //}
            //if (basket.Length == 3)
            //{
            //    return basket.Length * CostOfBook() * Discount(NumberOfDistinctBooks(basket));
            //}

            //return basket.Length * CostOfBook() * Discount(NumberOfDistinctBooks(basket));

        }

        private static int NumberOfDistinctBooks(int[] basket) => basket.ToList().Distinct().Count();

        private double Discount(int numberOfUniqueBooks)
        {
            if (numberOfUniqueBooks == 5)
            {
                return .75;
            }
            if (numberOfUniqueBooks == 4)
            {
                return .80;
            }

            if (numberOfUniqueBooks == 3)
            {
                return .90;
            }

            if (numberOfUniqueBooks == 2)
            {
                return 0.95;
            }

            return 1.00;
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
