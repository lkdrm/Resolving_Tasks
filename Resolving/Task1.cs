namespace Resolving
{
    /// <summary>
    /// Merge Sorted Array
    /// </summary>
    public static class MergeSortedArray
    {
        /// <summary>
        /// Resolving task about sorting array
        /// </summary>
        /// <returns>Sorted array</returns>
        public static int[] ResolvingTask(int[] firstArray, int m, int[] secondArray, int n)
        {
            int firstArrayLenght = m - 1;
            int secondArrayLenght = n - 1;
            int arrayLength = (m + n) - 1;
            while (secondArrayLenght >= 0)
            {
                if(firstArrayLenght >=0 && firstArray[firstArrayLenght] > secondArray[secondArrayLenght])
                {
                    firstArray[arrayLength] = firstArray[firstArrayLenght];
                    arrayLength--;
                    firstArrayLenght--;
                }
                else
                {   
                    firstArray[arrayLength] = secondArray[secondArrayLenght];
                    arrayLength--;
                    secondArrayLenght--;
                }
            }
            return firstArray;
        }
    }
}
