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
                return basket.Length * 8;
            }
            else if (basket.Length == 4)
            {
                return (basket.Length * 8) * 0.8;
            }
            else if (basket.Length == 2)
            {
                return (basket.Length * 8) * 0.9;
            }
            else
            {
                return (basket.Length * 8) * 0.95;
            }
            
        }

        private static bool CheckIfBasketHasDistinctBooksOrIsEmpty(int[] basket)
        {
            return basket.ToList().Distinct().Count() == 1 || basket.Length == 0;
        }
    }
}
