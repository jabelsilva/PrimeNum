using PrimeNumbers.Interfaces;
using System;
using System.Text;

namespace PrimeNumbers
{
    public class PrimeApp
    {
        #region Fields

        private readonly INumbers _numbers;
        private readonly IMatrixPrinter _print;
        private readonly IMatrixFormat _tableFormat;
        private int?[][] matrix;
        private int positiveInteger;

        #endregion Fields

        #region Ctor

        public PrimeApp(INumbers numbers, IMatrixFormat tableFormat, IMatrixPrinter printer)
        {
            _numbers = numbers;
            _print = printer;
            _tableFormat = tableFormat;
        }

        #endregion Ctor

        #region Public

        public void Start()
        {
            positiveInteger = GetPositiveInteger();
        }

        public void Process()
        {
            var list = _numbers.GetList(positiveInteger);
            matrix = _tableFormat.Get(list);
        }

        public void Print()
        {
            _print.Print(matrix);
        }

        #endregion Public

        #region Private
        
        protected virtual int GetPositiveInteger()
        {
            int number;
            string read = Read();
            if (!int.TryParse(read, out number))
            {
                WriteLine("input must be an integer.");
                return Retry();
            }

            if (1 > number)
            {
                WriteLine("input must be a positive integer.");
                return Retry();
            }

            return number;
        }

        protected virtual int Retry()
        {
            return GetPositiveInteger(); 
        }

        protected virtual string Read()
        {
            return Console.ReadLine();
        }

        protected virtual void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
        #endregion
    }
}
