using HackerRankLib;

//HackerRankLibHelper.Initialize(new HackerRankLibrary());
//var number = 123321;
//Console.WriteLine(HackerRankLibHelper.IsPalindrome(number) ? $"{number} it is" : $"{number} no is not");
//number = 6;
//Console.WriteLine(HackerRankLibHelper.StairCase(number));
//var array = new List<long>{ 256741038,623958417,467905213,714532089,938071625 };
//Console.WriteLine(HackerRankLibHelper.MiniMaxSum(array));
//const string strToCompress = "a24b2c56d4a2b2d3c6";
//Console.WriteLine($"Original:{strToCompress} Compressed:{HackerRankLibHelper.BetterCompression(strToCompress)}"); //expected: a26b4c62d7
//Console.ReadLine();

var numbers = new int[] { 32, 9, 529, 20, 15, 1041 };
Console.WriteLine($"Expected:5,  Obtained:{HackerRankLibHelper.MaxBinaryGaps(numbers)}");
Console.ReadLine();





// There are two int arrays, A and B.  Array A has M elements.
//Array B has N elements, but has a capacity of 2*M.
//Both arrays are sorted in ascending order.
//The combine arrays function will take in three parameters: 
//array A, array B, and M (the size of array A).
//Extend the combineArrays function to combine all numbers 
//from both arrays into the second array in a way that leaves 
//it sorted in ascending order.