using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumbers.UnitTests
{
    [TestClass]
    public class PrimeNumbersTests
    {
        #region Tests

        [TestMethod]
        public void GetList_EnterAPositiveNumber_ReurnTheSameNumberofItems()
        {
            int numberOfItems = 3;
            var primeNumbers = new PrimeNumbers();
            var list = primeNumbers.GetList(numberOfItems);

            Assert.AreEqual(list.Length, numberOfItems);
        }

        [TestMethod]
        public void GetList_EnterOneNumber_ReurnTheFirstPrimeNumber()
        {
            int numberOfItems = 1;
            int firstPrimeNumber = 2;
            var primeNumbers = new PrimeNumbers();
            var list = primeNumbers.GetList(numberOfItems);

            Assert.AreEqual(list[0], firstPrimeNumber);
        }

        #endregion Tests
    }
}
