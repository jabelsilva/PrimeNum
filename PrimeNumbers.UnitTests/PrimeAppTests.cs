using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using PrimeNumbers.Interfaces;

namespace PrimeNumbers.UnitTests
{
    [TestClass]
    public class PrimeAppTests
    {
        #region Tests

        [TestMethod]
        public void Process_ShouldCallGetList()
        {
            var numbers = Substitute.For<INumbers>();
            var printer = Substitute.For<IMatrixPrinter>();
            var matrix = Substitute.For<IMatrixFormat>();

            var primeApp = new PrimeApp(numbers, matrix, printer);
            primeApp.Process();

            numbers.Received().GetList(Arg.Any<int>());
        }

        [TestMethod]
        public void Process_ShouldCallTableFormatGet()
        {
            var numbers = Substitute.For<INumbers>();
            var printer = Substitute.For<IMatrixPrinter>();
            var matrix = Substitute.For<IMatrixFormat>();

            var primeApp = new PrimeApp(numbers, matrix, printer);
            primeApp.Process();

            matrix.Received().Get(Arg.Any<int[]>());
        }

        [TestMethod]
        public void Print_ShouldCallPrint()
        {
            var numbers = Substitute.For<INumbers>();
            var printer = Substitute.For<IMatrixPrinter>();
            var matrix = Substitute.For<IMatrixFormat>();

            var primeApp = new PrimeApp(numbers, matrix, printer);
            primeApp.Print();

            printer.Received().Print(Arg.Any<int?[][]>());
        }

        [TestMethod]
        public void Start_InputNonInteger_WriteMessageLine()
        {
            var numbers = Substitute.For<INumbers>();
            var printer = Substitute.For<IMatrixPrinter>();
            var matrix = Substitute.For<IMatrixFormat>();

            var primeApp = new FakePrimeApp(numbers, matrix, printer);
            primeApp.Start();

            Assert.IsTrue(primeApp.WriteMessage.Contains("input must be an integer"));
        }

        [TestMethod]
        public void Start_InputNegativeNumber_WriteMessageLine()
        {
            var numbers = Substitute.For<INumbers>();
            var printer = Substitute.For<IMatrixPrinter>();
            var matrix = Substitute.For<IMatrixFormat>();

            var primeApp = new FakePrimeApp(numbers, matrix, printer);
            primeApp.Input = "-1";
            primeApp.Start();

            Assert.IsTrue(primeApp.WriteMessage.Contains("input must be a positive integer."));
        }

        #endregion Tests

        #region Fake objects

        public class FakePrimeApp : PrimeApp
        {
            public string Input = "test";
            public string WriteMessage = "";

            public FakePrimeApp(INumbers numbers, IMatrixFormat matrix, IMatrixPrinter printer) : base(numbers, matrix, printer)
            {                
            }

            protected override string Read()
            {
                return Input;
            }

            protected override int Retry()
            {
                return 0;
            }
            

            protected override void WriteLine(string message)
            {
                WriteMessage = message;
            }
        }

        #endregion Fake objects

    }
}
