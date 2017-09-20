using PrimeNumbers.Interfaces;

namespace PrimeNumbers
{
    public class MatrixMultiplication : IMatrixFormat
    {
        #region Public
        
        /// <summary>
        /// Return a matrix of multiplications
        /// </summary>
        /// <param name="list">The array list</param>
        /// <returns></returns>
        public int?[][] Get(int[] list)
        {
            int?[][] table = new int?[list.Length + 1][];

            for (int y = 0; y <= list.Length; y++)
            {
                table[y] = new int?[list.Length + 1];

                //set first column
                if (y > 0)
                {
                    table[y][0] = list[y - 1];
                }

                for (int x = 0; x < list.Length; x++)
                {
                    if (y == 0)
                    {
                        table[y][x + 1] = list[x];
                    }
                    else
                    {
                        table[y][x + 1] = list[y - 1] * list[x];
                    }
                }
            }

            return table;
        }

        #endregion Public
    }
}
