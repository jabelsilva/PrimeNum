namespace PrimeNumbers.Interfaces
{
    public interface IMatrixFormat
    {
        /// <summary>
        /// Return a matrix of an array list
        /// </summary>
        /// <param name="list">The array list</param>
        /// <returns></returns>
        int?[][] Get(int[] list);
    }

}
