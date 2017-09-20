using PrimeNumbers.Interfaces;
using System;

namespace PrimeNumbers
{
    public class PrimeNumbers : INumbers
    {
        #region Public

        /// <summary>
        /// Get an array of n prime numbers
        /// </summary>
        /// <param name="numberOfItems">The number of prime items</param>
        /// <returns></returns>
        public int[] GetList(int numberOfItems)
        {
            var list = new int[numberOfItems];
            int nextPrime = 0;
            for (int i = 0; i < numberOfItems; i++)
            {
                nextPrime = GetNextPrime(nextPrime);

                list[i] = nextPrime;
            }

            return list;
        }

        #endregion Public

        #region Privates

        /// <summary>
        /// Get the next prime number
        /// </summary>
        /// <param name="nextPrime"></param>
        /// <returns></returns>
        private int GetNextPrime(int nextPrime)
        {
            if (nextPrime < 2)
                return 2;

            if (nextPrime == 2)
                return 3;

            do
            {
                nextPrime = nextPrime+2;
            }
            while (!IsPrime(nextPrime));
            

            return nextPrime;
        }

        /// <summary>
        /// Check if the number is a prime number
        /// </summary>
        /// <param name="number">The number to check</param>
        /// <returns></returns>
        private bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        #endregion Privates
    }
}
