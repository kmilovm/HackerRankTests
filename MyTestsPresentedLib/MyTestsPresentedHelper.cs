using MyTestsPresentedLib.Model;

namespace MyTestsPresentedLib
{
    public static class MyTestsPresentedLibHelper
    {
        private static IMyTestsPresentedLib? _MyTestsPresentedLib;

        public static string BetterCompression(string originalString)
        {
            return _MyTestsPresentedLib!.BetterCompression(originalString);
        }

        public static IEnumerable<string> BuildCartesianProduct(int[] arrA)
        {
            return _MyTestsPresentedLib!.BuildCartesianProduct(arrA);
        }

        public static int[] CombineArrays(int[] arrA, int[] arrB, int numberOfItemsToGrabOnA,
            int numberOfItemsToGrabOnB)
        {
            return _MyTestsPresentedLib!.CombineArrays(arrA, arrB, numberOfItemsToGrabOnA, numberOfItemsToGrabOnB);
        }

        public static int[] CyclicRotation(int[] initialArray, int rotations)
        {
            return _MyTestsPresentedLib!.CyclicRotation(initialArray, rotations);
        }

        public static int FindSmallestPositiveInteger(int[] baseNumbers, int maxNumber)
        {
            return _MyTestsPresentedLib!.FindSmallestPositiveInteger(baseNumbers, maxNumber);
        }

        public static int GetAverageTemperatureFromSensors(string[] datapoints, string[] sensors)
        {
            return _MyTestsPresentedLib!.GetAverageTemperatureFromSensors(datapoints, sensors);
        }

        public static void Initialize(IMyTestsPresentedLib MyTestsPresentedLib)
        {
            _MyTestsPresentedLib = MyTestsPresentedLib;
        }

        public static bool IsPalindrome(int number)
        {
            return _MyTestsPresentedLib!.IsPalindrome(number);
        }

        public static int MaxBinaryGaps(int[] numbers)
        {
            return _MyTestsPresentedLib!.MaxBinaryGaps(numbers);
        }

        public static string MiniMaxSum(List<long> arrayNumbers)
        {
            return _MyTestsPresentedLib!.MiniMaxSum(arrayNumbers);
        }

        public static Tuple<string, int> PossibleSuccessiveCombinations(Tree node, int numberOfSuccessiveNumbers, bool allowDuplicates)
        {
            return _MyTestsPresentedLib!.PossibleSuccessiveCombinations(node, numberOfSuccessiveNumbers, allowDuplicates);
        }

        public static string PossibleTwoSums(int target, int arrayLength)
        {
            return _MyTestsPresentedLib!.PossibleTwoSums(target, arrayLength);
        }

        public static string StairCase(int number)
        {
            return _MyTestsPresentedLib!.StairCase(number);
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            return _MyTestsPresentedLib!.TwoSum(numbers, target);
        }

        public static ListNode AddTwoNumbers(ListNode list1, ListNode list2)
        {
            return _MyTestsPresentedLib!.AddTwoNumbers(list1, list2);
        }
    }
}
