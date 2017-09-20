using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers.UnitTests
{
    [TestClass]
    public class MatrixPrinterConsoleTests
    {
        #region Tests
        
        [TestMethod]
        public void Print_ArrayWith2Items_ShouldWrite2Columns()
        {
            var callWrite = 2;
            var printer = new FakeMatrixPrinterConsole();
            int?[][] array = new int?[1][];
            array[0] = new int?[2] { 7, 9 };
            
            printer.Print(array);

            Assert.AreEqual(printer.CallWrite, callWrite);
        }

        [TestMethod]
        public void Print_ArrayWith2Items_ShouldWrite2Rows()
        {
            var callWrite = 2;
            var printer = new FakeMatrixPrinterConsole();
            int?[][] array = new int?[2][];
            array[0] = new int?[2] { 7, 9 };
            array[1] = new int?[2] { 7, 9 };

            printer.Print(array);

            Assert.AreEqual(printer.CallWriteLine, callWrite);
        }

        public class FakeMatrixPrinterConsole : MatrixPrinterConsole
        {
            public int CallWrite = 0;
            public int CallWriteLine = 0;

            protected override void Write(string text)
            {
                CallWrite++;
            }

            protected override void WriteLine()
            {
                CallWriteLine++;
            }
        }

        #endregion Tests
    }
}
