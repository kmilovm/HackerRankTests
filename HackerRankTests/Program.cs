Console.WriteLine("Hello, World!");
var numero = 123321;
Console.WriteLine(EsPalindromo(numero) ? $"{numero} si lo es" : $"{numero} no lo es");
numero = 6;
Console.WriteLine(StairCase(numero));
var array = new List<long>{ 256741038,623958417,467905213,714532089,938071625 };
Console.WriteLine(MiniMaxSum(array));
const string strToCompress = "a24b2c56d4a2b2d3c6";
Console.WriteLine($"Original:{strToCompress} Compressed:{ BetterCompression(strToCompress)}"); //expected: a26b4c62d7
Console.ReadLine();

static bool EsPalindromo(int numero)
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

static string StairCase(int numero)
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

static string MiniMaxSum(List<long> arr)
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

static string BetterCompression(string str)
{
    char letter = default;
    var number = string.Empty;
    char prevLetter = default;
    var list = new SortedDictionary<char, int>();
    for (var idx=0;idx<=str.ToCharArray().Length-1;idx++)
    {
        var chr = str[idx];
        var last = idx == str.ToCharArray().Length - 1;
        if (char.IsLetter(chr))
        {
            SetValuesIntoArray(number, prevLetter, list);
            letter = chr;
            number = string.Empty;
            prevLetter = letter;
        }

        if (!last)
        {
            if (letter != default && char.IsNumber(chr))
            {
                number += chr;
            }
        }
        else
        {
            number += chr;
            SetValuesIntoArray(number, prevLetter, list);
        }
    }
    return string.Join("", list.Select(x => $"{x.Key}{x.Value}"));
}

static void SetValuesIntoArray(string number, char prevLetter, IDictionary<char, int> sortedDictionary)
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

static string possibleTwoSums(int target)
{
    const int maxNumber = 9;
    var results = new List<Tuple<int, int>>();

    for (var i = 1; i <= maxNumber; i++)
    {
        for (var j = i + 1; j <= maxNumber; j++)
        {
            var sum = i + j;
            if (sum != target) continue;
            Console.WriteLine($"[{i},{j}]");
            results.Add(new Tuple<int, int>(i, j));
        }
    }
    return string.Join(",", results.Select(x => $"[{x.Item1},{x.Item2}]"));
}