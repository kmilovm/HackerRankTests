using HackerRankLib.Model;

namespace HackerRankLib
{
    public interface IHackerRankLib
    {
        bool IsPalindrome(int number);

        string StairCase(int number);

        string MiniMaxSum(List<long> arr);

        string BetterCompression(string str);

        string PossibleTwoSums(int target, int arrayLength);

        Tuple<string, int> PossibleSuccessiveCombinations(Tree? node, int numberOfSuccessiveNumbers);
    }
}
