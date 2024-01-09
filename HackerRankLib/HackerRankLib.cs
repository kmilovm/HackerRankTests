using System.Reflection;
using System.Text;

namespace HackerRankLib
{
    public class HackerRankLibrary : IHackerRankLib
    {
        public bool IsPalindrome(int numero)
        {
            var numeroOriginal = numero;
            var numeroInvertido = 0;

            while (numero > 0)
            {
                var digito = numero % 10;
                numeroInvertido = (numeroInvertido * 10) + digito;
                numero /= 10;
            }


            return numeroOriginal == numeroInvertido;
        }

        public string StairCase(int numero)
        {
            var arr = Enumerable.Range(1, numero); //1,2,3,4,5,6 when n=6
            var result = string.Empty;
            var enumerable = arr.ToList();
            foreach (var item in enumerable)
            {
                var partialResult = string.Empty;
                for (var j = 0; j < item; j++)
                {
                    partialResult += "#";
                }
                partialResult = partialResult.PadLeft(numero, ' ');
                result += partialResult + Environment.NewLine;
            }
            return result;
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

        public List<Type> GetTypesFromNamespace(Assembly currentAssembly, string namespaceName)
        {
            var types = currentAssembly.GetReferencedAssemblies()
                .Select(Assembly.Load)
                .SelectMany(asm => asm.GetTypes())
                .Where(type => type.IsClass &&
                               !type.IsPublic &&
                               !type.IsNestedPublic &&
                               type.Namespace != null &&
                               type.Namespace.IndexOf(namespaceName, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            return types.ToList();
        }
    }
}