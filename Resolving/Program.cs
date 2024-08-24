using Resolving;

#region Start
Console.Title = "Codes result";
var legendDefault = ConsoleColor.Green;
Console.ForegroundColor = legendDefault;
Console.WriteLine("Here u can see the resolved tasks!");
#endregion

var mergeSortedArrayTask1 = new MergeSortedArray().ResolvingTask(firstArray: [1, 2, 3, 0, 0, 0], m: 3, secondArray: [2, 5, 6], n: 3);
Console.WriteLine("First [{0}]", string.Join(",", mergeSortedArrayTask1));
var mergeSortedArrayTask2 = new MergeSortedArray().ResolvingTask(firstArray: [1], m: 1, secondArray: [], n: 0);
Console.WriteLine("Second [{0}]", string.Join(",", mergeSortedArrayTask2));
var mergeSortedArrayTask3 = new MergeSortedArray().ResolvingTask(firstArray: [0], m: 0, secondArray: [1], n: 1);
Console.WriteLine("Third [{0}]", string.Join(",", mergeSortedArrayTask3));