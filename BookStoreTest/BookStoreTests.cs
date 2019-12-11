using System;
using BookStoreExercism;
using NUnit.Framework;

namespace BookStoreTest
{
    public class BookStoreTests
    {
        private BookStore bookStore;

        [SetUp]
        public void CreateBookStore()
        {
            bookStore = new BookStore();
        }

        [Test]
        public void CostOfOneBook()
        {
            var basket = new int[] {1};
            Assert.AreEqual(8, bookStore.CalculateTotal(basket));
        }

        [Test]
        public void CostOfTwoSameBooks()
        {
            var basket = new int[] {2, 2};
            Assert.AreEqual(16, bookStore.CalculateTotal(basket));
        }

        [Test]
        public void CostOfZeroBooksInBasket()
        {
            var basket = new int[] {};
            Assert.AreEqual(0, bookStore.CalculateTotal(basket));
        }

        [Test]
        public void CostOfTwoDifferentBooks()
        {
            var basket = new int[] { 1, 2 };
            Assert.AreEqual(15.2, bookStore.CalculateTotal(basket));
        }

        [Test]
        public void CostOfThreeDifferentBooks()
        {
            var basket = new int[] {1, 2, 3};
            Assert.AreEqual(21.6, bookStore.CalculateTotal(basket));
        }

        [Test]
        public void CostOfFourDifferentBooks()
        {
            var basket = new int[] { 1, 2, 3, 4 };
            Assert.AreEqual(25.6, bookStore.CalculateTotal(basket));
        }

        [Test]
        public void CostOfFiveDifferentBooks()
        {
            var basket = new int[] { 1, 2, 3, 4, 5 };
            Assert.AreEqual(30.0, bookStore.CalculateTotal(basket));
        }

        [Test]
        public void CostOfTwoSameBookAndOneDifferentBook()
        {
            var basket = new int[] { 1, 1, 2};
            Assert.AreEqual(23.2, bookStore.CalculateTotal(basket));
        }

        [Test]
        public void CostOfPairOfTwoDifferentBooks()
        {
            var basket = new int[] { 1, 1, 2, 2 };
            Assert.AreEqual(30.399999999999999, bookStore.CalculateTotal(basket));
        }

        [Test]
        public void OneGroupOfFiveBooksAndOneGroupOfThreeBooks()
        {
            var basket = new int[] {1, 1, 2, 2, 3, 3, 4, 5};
            Assert.AreEqual(51.60, bookStore.CalculateTotal(basket));
        }

        [Test]
        public void TwoGroupsOfFourBooks()
        {
            var basket = new int[] { 1, 1, 2, 2, 3, 3, 4, 5 };
            Assert.AreEqual(51.20, bookStore.CalculateTotal(basket));
        }
    }
}
