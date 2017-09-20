using System;
using PrimeNumbers.Interfaces;

namespace PrimeNumbers
{
    public class MatrixPrinterConsole : IMatrixPrinter
    {
        #region Public

        /// <summary>
        /// Print a matrix on console application
        /// </summary>
        /// <param name="table"></param>
        public void Print(int?[][] table)
        {
            for (int y = 0; y < table.Length; y++)
            {
                for (int x = 0; x < table[y].Length; x++)
                {
                    Write(string.Format("{0,5} |", table[y][x]));
                }
                WriteLine();
            }
        }

        #endregion Public

        #region Privates

        protected virtual void Write(string text)
        {
            Console.Write(text);
        }

        protected virtual void WriteLine()
        {
            Console.WriteLine();
        }

        #endregion Privates
    }
}
