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

        /// <summary>
        /// Third variant where you can have same number only twice
        /// </summary>
        /// <param name="numbers">Array numbers</param>
        /// <returns>Removed duplicate array</returns>
        public static int[] Resolving3(int[] numbers)
        {
            int currentNumber = int.MinValue;
            int twice = 0;
            List<int> result = [];

            foreach (int number in numbers)
            {
                if (currentNumber != number)
                {
                    twice = 0;
                }
                currentNumber = number;
                if(currentNumber == number && twice < 2)
                {
                    result.Add(currentNumber);
                    twice++;
                }
            }
            return result.ToArray();
        }
    }
}
