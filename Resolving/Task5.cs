using System.Collections.Frozen;

namespace Resolving
{
    /// <summary>
    /// Majority of the array
    /// </summary>
    public static class MajorityElement
    {
        /// <summary>
        /// Resolving task about find Majority of numbers
        /// </summary>
        /// <param name="numbers">Array of numbers</param>
        /// <returns>Found majority</returns>
        public static string Resolve(int[] numbers)
        {
            var fset = numbers.ToFrozenSet();

            Dictionary<int, int> result = [];

            foreach (int n in fset)
            {
                result.Add(n, 0);
            }

            foreach (int numb in result.Keys)
            {
                int majority = 0;
                foreach (int i in numbers)
                {
                    if (numb == i)
                    {
                        majority++;
                    }
                }
                if (majority > 0)
                {
                    result[numb] = majority;
                }
            }

            var resultKeyValue = result.Aggregate((x, y) => x.Value > y.Value ? x : y);

            return $"The majority of the Array is :[{resultKeyValue.Key}, {resultKeyValue.Value}]";
        }
    }
}
