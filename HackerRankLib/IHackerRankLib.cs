using System.Reflection;

namespace HackerRankLib
{
    public interface IHackerRankLib
    {
        bool IsPalindrome(int numero);

        string StairCase(int numero);

        string MiniMaxSum(List<long> arr);

        string BetterCompression(string str);

        string PossibleTwoSums(int target, int arrayLength);

        List<Type> GetTypesFromNamespace(Assembly currentAssembly, string namespaceName);
    }
}
