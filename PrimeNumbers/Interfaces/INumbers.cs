namespace PrimeNumbers.Interfaces
{

    /// <summary>
    /// Interface Numbers
    /// </summary>
    public interface INumbers
    {
        /// <summary>
        /// Get an array with a number of items
        /// </summary>
        /// <param name="numberOfItems">The number of returning items</param>
        /// <returns></returns>
        int[] GetList(int numberOfItems);
    }

}
