using System.Text;
using HackerRankLib.Model;

namespace HackerRankLib;

public class FunctionsHelper
{

    public static void FindConsecutiveNumbersHelper(Tree? node, List<int> currentPath, ICollection<List<int>> result, int n)
    {
        while (true)
        {
            if (node == null) return;

            currentPath.Add(node.Value);

            if (currentPath.Count == n)
            {
                Console.WriteLine(currentPath);
                result.Add([..currentPath]);
                currentPath.RemoveAt(0);
            }

            FindConsecutiveNumbersHelper(node.LeftTree, [..currentPath], result, n);
            node = node.RightTree;
            currentPath = [..currentPath];
        }
    }


    public static Tuple<string, int> PossibleSuccessiveCombinationsRecursive(Tree? root, int numberOfSuccessiveNumbers)
    {
        var result = new List<List<int>>();
        var numbersOnString = new StringBuilder();
        FindConsecutiveNumbersHelper(root, new List<int>(), result, numberOfSuccessiveNumbers);
        result.ForEach(numbers =>
        {
            numbersOnString.AppendLine(string.Join("", numbers));
        });
        return new Tuple<string, int>(numbersOnString.ToString(), result.Count);
    }

    public static void SetValuesIntoArray(string number, char prevLetter, IDictionary<char, int> sortedDictionary)
    {
        if (string.IsNullOrEmpty(number)) return;
        if (prevLetter == default) return;
        if (!sortedDictionary.ContainsKey(prevLetter))
        {
            sortedDictionary.Add(prevLetter, Convert.ToInt32(number));
        }
        else
        {
            sortedDictionary[prevLetter] += Convert.ToInt32(number);
        }
    }
}