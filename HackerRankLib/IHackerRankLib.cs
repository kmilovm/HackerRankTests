using HackerRankLib.Model;

namespace HackerRankLib
{
    public interface IHackerRankLib
    {
        string BetterCompression(string str);

        int FindSmallestPositiveInteger(int[] baseNumbers, int maxValue);

        bool IsPalindrome(int number);

        string MiniMaxSum(List<long> arr);

        Tuple<string, int> PossibleSuccessiveCombinations(Tree? node, int numberOfSuccessiveNumbers);

        string PossibleTwoSums(int target, int arrayLength);

        string StairCase(int number);
    }
}
