namespace HackerRankLib
{
    public static class HackerRankLibHelper
    {
        private static IHackerRankLib? _hackerRankLib;

        public static void Initialize(IHackerRankLib hackerRankLib)
        {
            _hackerRankLib = hackerRankLib;
        }

        public static bool IsPalindrome(int number)
        {
            return _hackerRankLib!.IsPalindrome(number);
        }

        public static string StairCase( int number)
        {
            return _hackerRankLib!.StairCase(number);
        }
        public static string MiniMaxSum(List<long> arrayNumbers)
        {
            return _hackerRankLib!.MiniMaxSum(arrayNumbers);
        }

        public static string BetterCompression( string originalString)
        {
            return _hackerRankLib!.BetterCompression(originalString);
        }

        public static string PossibleTwoSums( int target, int arrayLength)
        {
            return _hackerRankLib!.PossibleTwoSums(target,arrayLength);
        }
    }
}
