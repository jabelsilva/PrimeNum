using System;

namespace PrimeNumbers
{
    partial class Program
    {
        static void Main(string[] args)
        {

            var primeNumbers = new PrimeNumbers();
            var printer = new MatrixPrinterConsole();
            var matrixFormat = new MatrixMultiplication();

            PrimeApp primeApp = new PrimeApp(primeNumbers, matrixFormat, printer);
            primeApp.Start();
            primeApp.Process();
            primeApp.Print();

            Console.Read();
        }
        
    }
}
