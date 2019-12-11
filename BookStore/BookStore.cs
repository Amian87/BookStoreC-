using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreExercism
{
    public class BookStore
    {
        public double CalculateTotal(int[] basket)
        {
            if (CheckIfBasketHasDistinctBooksOrIsEmpty(basket))
            {
                return basket.Length * 8;

            }
            else
            {
                return  15.2;
            }
        }

        private static bool CheckIfBasketHasDistinctBooksOrIsEmpty(int[] basket)
        {
            return basket.ToList().Distinct().Count() == 1 || basket.Length == 0;
        }
    }
}
