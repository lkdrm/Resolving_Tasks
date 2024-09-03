using System.Collections.Frozen;

namespace Resolving
{
    /// <summary>
    /// Remove Duplicate
    /// </summary>
    public static class RemoveDuplicate
    {
        /// <summary>
        /// First variant with using FrozenSet
        /// </summary>
        /// <param name="numbers">Array numbers</param>
        /// <returns>Removed duplicate array</returns>
        public static int[] Resolving(int[] numbers) => numbers.ToFrozenSet().ToArray();

        /// <summary>
        /// Second variant with running whole array
        /// </summary>
        /// <param name="numbers">Array numbers</param>
        /// <returns>Removed duplicate array</returns>
        public static int[] Resolving2(int[] numbers)
        {
            int currentNumber = int.MinValue;
            List<int> result = [];

            foreach (int number in numbers)
            {
                if (currentNumber != number)
                {
                    result.Add(number);
                }
                currentNumber = number;
            }
            return result.ToArray();
        }
    }
}
