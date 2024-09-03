namespace Resolving
{
    /// <summary>
    /// Remove Element
    /// </summary>
    public static class RemoveElement
    {
        /// <summary>
        /// Resolving task
        /// </summary>
        /// <param name="numbers">Array of numbers</param>
        /// <param name="removeValue">Which number/s will be removed from array</param>
        /// <returns>Array with need numbers</returns>
        public static int[] Resolving(int[] numbers, int removeValue) => numbers.Where(number => number != removeValue).ToArray();
    }
}
