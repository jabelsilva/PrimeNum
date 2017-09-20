using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumbers.UnitTests
{
    [TestClass]
    public class MatrixMultiplicationTests
    {
        #region Tests
        
        [TestMethod]
        public void Get_AddIntList_ReturnAMultiplicationTable()
        {
            var table = new MatrixMultiplication();

            var array = new int[] { 1, 2, 3, 4 };
            var arrayTable = table.Get(array);

            //row 1
            Assert.AreEqual(arrayTable[1][1], 1);
            Assert.AreEqual(arrayTable[1][2], 2);
            Assert.AreEqual(arrayTable[1][3], 3);
            Assert.AreEqual(arrayTable[1][4], 4);

            //row 2
            Assert.AreEqual(arrayTable[2][1], 2);
            Assert.AreEqual(arrayTable[2][2], 4);
            Assert.AreEqual(arrayTable[2][3], 6);
            Assert.AreEqual(arrayTable[2][4], 8);

            //row 3
            Assert.AreEqual(arrayTable[3][1], 3);
            Assert.AreEqual(arrayTable[3][2], 6);
            Assert.AreEqual(arrayTable[3][3], 9);
            Assert.AreEqual(arrayTable[3][4], 12);

            //row 4
            Assert.AreEqual(arrayTable[4][1], 4);
            Assert.AreEqual(arrayTable[4][2], 8);
            Assert.AreEqual(arrayTable[4][3], 12);
            Assert.AreEqual(arrayTable[4][4], 16);

        }
        
        #endregion Tests
    }
}
