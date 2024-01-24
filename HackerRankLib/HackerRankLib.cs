using System.Text;
using HackerRankLib.Model;

namespace HackerRankLib
{
    public class HackerRankLibrary : IHackerRankLib
    {
        /// <summary>
        /// Joseph and Jane are making a contest for apes. During the process, they have to communicate frequently with each other. Since they are not completely human,
        /// they cannot speak properly. They have to transfer messages using postcards of small sizes.
        /// To save space on the small postcards, they devise a string compression algorithm.
        /// • If a character, ch, occurs n(> 1) times in a row, then it will be represented by {ch}{r],
        ///     where {a} is the value of x.For example, if the substring is a sequence of 4 'a' ("aaaa"), it will be represented as "a4".
        /// • If a character, ch, occurs exactly one time in a row, then it will be simply represented as {ch}. For example, if the substring
        ///     is "a", then it will be represented as "a".
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public string BetterCompression(string str)
        {
            var number = new StringBuilder();
            char prevLetter = default;
            var list = new SortedDictionary<char, int>();

            foreach (var chr in str)
            {
                if (char.IsLetter(chr))
                {
                    SetValuesIntoArray(number.ToString(), prevLetter, list);
                    number.Clear();
                    prevLetter = chr;
                }
                else if (char.IsDigit(chr))
                {
                    number.Append(chr);
                }
                else
                {
                    throw new ArgumentException($"Invalid character: {chr}");
                }
            }

            SetValuesIntoArray(number.ToString(), prevLetter, list);
            return string.Join("", list.Select(x => $"{x.Key}{x.Value}"));
        }

        /// <summary>
        /// Finds the smallest positive integer. given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
        /// For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
        /// Given A = [1, 2, 3], the function should return 4.
        /// Given A = [−1, −3], the function should return 1.
        /// Write an efficient algorithm for the following assumptions:
        /// N is an integer within the range [1..100,000];
        /// each element of array A is an integer within the range [−1,000,000..1,000,000].
        /// </summary>
        /// <param name="baseNumbers">The base numbers.</param>
        /// <param name="maxValue">The maximum int value.</param>
        /// <returns></returns>
        public int FindSmallestPositiveInteger(int[] baseNumbers, int maxValue)
        {
            var foundNumbers = new HashSet<int>();

            foreach (var num in baseNumbers)
            {
                foundNumbers.Add(num);
            }

            for (var i = 1; i <= maxValue; i++)
            {
                if (!foundNumbers.Contains(i))
                {
                    return i;
                }
            }

            return -1;
        }
        /// <summary>
        /// Determines whether the specified number is palindrome.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>
        ///   <c>true</c> if the specified number is palindrome; otherwise, <c>false</c>.
        /// </returns>
        public bool IsPalindrome(int number)
        {
            var original = number;
            var inverted = 0;

            while (number > 0)
            {
                var digit = number % 10;
                inverted = (inverted * 10) + digit;
                number /= 10;
            }
            
            return original == inverted;
        }

        /// <summary>
        /// Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.
        /// Then print the respective minimum and maximum values as a single line of two space-separated long integers.
        /// Example
        /// Arr = [1,3,5,7,9]
        /// The minimum sum is 1+3+5+7=16 and the maximum sum is 3+5+7+9=24. The function prints 16 24
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public string MiniMaxSum(List<long> arr)
        {
            var resultArray = new List<long>();
            foreach (var item in arr)
            {
                var tempArr = new List<long>();
                tempArr.AddRange(arr);
                tempArr.Remove(item);
                resultArray.Add(tempArr.Sum());
            }

            return $"{resultArray.Min()} {resultArray.Max()}";
        }

        /// <summary>
        /// The problem focuses on binary trees, represented by pointer data structures.
        /// A node of a binary tree contains a single digit and pointers to two other nodes, called the left subtree and the right subtree. If left subtree or right subtree does not exist, its corresponding pointer value is null.
        /// For example, the figure below shows a binary tree consisting of seven nodes. Its root contains the value 1, and the roots of its left and right subtrees contain the values 2 and 7, respectively. In this example, the nodes with values 5 and 7 do not have right subtrees - their right subtrees are empty. The nodes containing values 3, 4 and 9 are leaves - their left and right subtrees are both empty.
        /// Assume that the following declarations are given:
        /// class Tree {
        /// public int x;
        /// public Tree l;
        /// public Tree r;
        /// };
        /// An empty tree is represented by null. A non-empty tree is represented by an object representing its root. The attribute x holds the integer contained in the node, whereas attributes l and r hold the left and right subtrees, respectively.
        /// In this problem, nodes of the tree contain digits. A three-digit number can be created in the following way:
        /// choose some node x from the tree;
        /// choose some node y which is the left or right subtree of x;
        /// choose some node z which is the left or right subtree of y;
        /// concatenate the digits contained in nodes x, y, z (in that order) to obtain a three-digit number.
        /// In other words, you choose some node in the tree, move exactly two edges down the tree and concatenate the digits encountered on the way. For example, in the tree presented above, you can create number 253 by starting in the node containing value 2 and then going down to the left subtree twice:
        /// Your task is to count the number of different three-digit numbers that can be created this way. Note that while some numbers may be able to be created in different ways, each number should be counted only once.
        /// Write a function:
        /// class Solution { public int solution(Tree T); }
        /// that, given a binary tree T consisting of N nodes, returns the number of different three-digit numbers that can be created as described above.
        /// Examples:
        /// Given a tree T described in the example above which could also be denoted as:
        /// css
        /// Copy code
        /// (1, (2, (5, (3, None, None), None), (9, None, None)), (7, (4, None, None), None))
        /// the function should return 4. You can create the following numbers: 125, 253, 129, 174.
        /// 2. Given a tree T:
        /// The function should return 5. You can create the following numbers: 992, 999, 959, 595, 599. Number 959 can be created in three different ways but it should be counted only once in the answer.
        /// Write an efficient algorithm for the following assumptions:
        /// N is an integer within the range [1..30,000];
        /// each value in tree T is a digit within the range [1..9].*/
        /// </summary>
        /// <param name="node"></param>
        /// <param name="numberOfSuccessiveNumbers"></param>
        /// <returns>
        ///   <br />
        /// </returns>
        public Tuple<string, int> PossibleSuccessiveCombinations(Tree? node, int numberOfSuccessiveNumbers)
        {
            return PossibleSuccessiveCombinationsRecursive(node, numberOfSuccessiveNumbers);
        }

        /// <summary>
        /// Possibles the two sums.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="arrayLength">Length of the array.</param>
        /// <returns></returns>
        public string PossibleTwoSums(int target, int arrayLength)
        {
            var results = new List<Tuple<int, int>>();

            for (var i = 1; i <= arrayLength; i++)
            {
                for (var j = i + 1; j <= arrayLength; j++)
                {
                    var sum = i + j;
                    if (sum != target) continue;
                    results.Add(new Tuple<int, int>(i, j));
                }
            }
            return string.Join(",", results.Select(x => $"[{x.Item1},{x.Item2}]"));
        }

        /// <summary>
        /// Creates a Stair based on the values of the array.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public string StairCase(int number)
        {
            var arr = Enumerable.Range(1, number); //1,2,3,4,5,6 when n=6
            var result = new StringBuilder();
            var enumerable = arr.ToList();
            foreach (var item in enumerable)
            {
                var partialResult = new StringBuilder();
                for (var j = 0; j < item; j++)
                {
                    partialResult.Append('#');
                }
                result.AppendLine(partialResult.ToString());
            }
            return result.ToString();
        }
        
        private static void FindConsecutiveNumbersHelper(Tree? node, List<int> currentPath, ICollection<List<int>> result, int n)
        {
            while (true)
            {
                if (node == null) return;

                currentPath.Add(node.Value);

                if (currentPath.Count == n)
                {
                    result.Add(new List<int>(currentPath));
                    currentPath.RemoveAt(0);
                }

                FindConsecutiveNumbersHelper(node.LeftTree, new List<int>(currentPath), result, n);
                node = node.RightTree;
                currentPath = new List<int>(currentPath);
            }
        }


        private static Tuple<string, int> PossibleSuccessiveCombinationsRecursive(Tree? root, int numberOfSuccessiveNumbers)
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

        private static void SetValuesIntoArray(string number, char prevLetter, IDictionary<char, int> sortedDictionary)
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
        
        public int GetAverageTemperatureFromSensors(string[] datapoints, string[] sensors)
        {
            var sensorData = new Dictionary<string, List<int>>();
            foreach (var t in datapoints)
            {
                var entry = t.Split('_');
                var sensorId = entry[0];
                var temp = int.Parse(entry[1]);

                if (!Array.Exists(sensors, id => id == sensorId)) continue;
                if (!sensorData.ContainsKey(sensorId))
                {
                    sensorData[sensorId] = new List<int>();
                }
                sensorData[sensorId].Add(temp);
            }

            var sensorAverages = (from sensorId in sensors where sensorData.ContainsKey(sensorId) select sensorData[sensorId].Average() into average select (int)Math.Round(average, MidpointRounding.AwayFromZero)).ToList();

            var overAllAverage = sensorAverages.Count > 0 ? (int)Math.Round(sensorAverages.Average(), MidpointRounding.AwayFromZero) : 0;
            return overAllAverage;
        }

    }
}



  