using System.Linq;

namespace BookStoreExercism
{
    public class BookStore
    {
        public double CalculateTotal(int[] basket)
        {
            double totalCost = 0;

            var  uniqueBooks = basket.ToList().Distinct();

            var duplicateBooks =    basket.ToList().GroupBy(x => x)
                                          .Where(group => group.Count() > 1)
                                          .Select(group => group.Key);

            if (uniqueBooks.Any())
            {
                totalCost = uniqueBooks.Count() * CostOfBook() * Discount(uniqueBooks.Count());
            }

            if (duplicateBooks.Any())
            {
                totalCost += duplicateBooks.Count() * CostOfBook() * Discount(duplicateBooks.Count());
            }
            return totalCost;

        }

        //private static int NumberOfDistinctBooks(int[] basket) => basket.ToList().Distinct().Count();

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

    }
}
