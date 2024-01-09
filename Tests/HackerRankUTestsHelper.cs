using System.Reflection;
using HackerRankLib;

namespace Tests
{
    public static class HackerRankUTestsHelper
    {
        public static bool IsPalindrome(IHackerRankLib hackerRankLib, int number)
        {
            return hackerRankLib.IsPalindrome(number);
        }

        public static string StairCase(IHackerRankLib hackerRankLib, int number)
        {
            return hackerRankLib.StairCase(number);
        }
        public static string MiniMaxSum(IHackerRankLib hackerRankLib, List<long> arrayNumbers)
        {
            return hackerRankLib.MiniMaxSum(arrayNumbers);
        }

        public static string BetterCompression(IHackerRankLib hackerRankLib, string originalString)
        {
            return hackerRankLib.BetterCompression(originalString);
        }

        public static string PossibleTwoSums(IHackerRankLib hackerRankLib, int target, int arrayLength)
        {
            return hackerRankLib.PossibleTwoSums(target,arrayLength);
        }

        public static List<Type> GetAssemblies(IHackerRankLib hackerRankLib, Assembly asm, string namespaceName)
        {
            return hackerRankLib.GetTypesFromNamespace(asm, namespaceName);
        }
    }
}
