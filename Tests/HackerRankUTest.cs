using AutoFixture;
using HackerRankLib;
using HackerRankLib.Model;
using Xunit.Abstractions;

namespace Tests
{
    public class HackerRankUTest
    {
        private readonly Fixture _fixture;
        private readonly ITestOutputHelper _testOutputHelper;
        public HackerRankUTest(ITestOutputHelper testOutputHelper)
        {
            HackerRankLibHelper.Initialize(new HackerRankLibrary());
            _testOutputHelper = testOutputHelper;
            _fixture = new Fixture();
        }

   

        [Fact]

        public void BetterCompressionSuccess()
        {
            const string original = "a2b3c4a5b4c3d7";
            const string expected = "a7b7c7d7";
            var answer = HackerRankLibHelper.BetterCompression(original);
            _testOutputHelper.WriteLine(answer);
            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData(12345)]
        public void IsPalindromeFailure(int number)
        {
            var answer = HackerRankLibHelper.IsPalindrome(number);
            Assert.False(answer);
        }

        [Theory]
        [InlineData(12321)]
        public void IsPalindromeSuccess(int number)
        {
            var answer = HackerRankLibHelper.IsPalindrome( number);
            Assert.True(answer);
        }

        [Fact]
        public void MiniMaxSumSuccess()
        {
            var numbers = _fixture.CreateMany<long>(5);
            var enumerable = numbers as long[] ?? numbers.ToArray();
            var answer = HackerRankLibHelper.MiniMaxSum(enumerable.ToList());
            _testOutputHelper.WriteLine(string.Join(',', enumerable.ToList()));
            _testOutputHelper.WriteLine(answer);
            Assert.NotEmpty(answer);
        }

        [Theory]
        [MemberData(nameof(TestData.TreeTestData), MemberType = typeof(TestData))]
        public void PossibleSuccessiveNumbers(Tree treeData, int numberOfSuccessiveNumbers)
        {
            var answer = HackerRankLibHelper.PossibleSuccessiveCombinations(treeData, numberOfSuccessiveNumbers);
            _testOutputHelper.WriteLine(answer.Item1);
            _testOutputHelper.WriteLine(answer.Item2.ToString());
            Assert.NotEmpty(answer.ToString());
        }

        [Theory]
        [InlineData(25, 9)]

        public void PossibleTwoSumsFailure(int target, int arrayLength)
        {
            var answer = HackerRankLibHelper.PossibleTwoSums(target, arrayLength);
            _testOutputHelper.WriteLine(answer);
            Assert.Empty(answer);
        }

        [Theory]
        [InlineData(13, 9)]

        public void PossibleTwoSumsSuccess(int target, int arrayLength)
        {
            var answer = HackerRankLibHelper.PossibleTwoSums(target, arrayLength);
            _testOutputHelper.WriteLine(answer);
            Assert.NotEmpty(answer);
        }

        [Theory]
        [InlineData(5)]

        public void StairCaseSuccess(int number)
        {
            var answer = HackerRankLibHelper.StairCase(number);
            _testOutputHelper.WriteLine(answer);
            Assert.NotEmpty(answer);
        }

        [Theory]
        [MemberData(nameof(TestData.IntTestData), MemberType = typeof(TestData))]

        public void FindSmallestPositiveNumber(int[] baseNumbers, int maxValue)
        {
            var answer = HackerRankLibHelper.FindSmallestPositiveInteger(baseNumbers, maxValue);
            _testOutputHelper.WriteLine(string.Join(",",baseNumbers));
            _testOutputHelper.WriteLine(answer.ToString());
            Assert.NotEqual(-1,answer);
        }

        [Theory]
        [MemberData(nameof(TestData.TempTestData), MemberType = typeof(TestData))]

        public void GetAverageTemperatureFromSensors(string[] dataPoints, string[] sensors)
        {
            const int expectedValue = 300;
            var answer = HackerRankLibHelper.GetAverageTemperatureFromSensors(dataPoints, sensors);
            _testOutputHelper.WriteLine($"Expected: {expectedValue}, Got {answer}");
            Assert.NotEqual(-1, answer);
            Assert.Equal(expectedValue, answer);
        }

        [Theory]
        [InlineData( new[]{ 32, 9, 529, 20, 15, 1041 })]

        public void MaxBinaryGaps(int[] numbers)
        {
            const int expectedValue = 5;
            var answer = HackerRankLibHelper.MaxBinaryGaps(numbers);
            _testOutputHelper.WriteLine($"Expected: {expectedValue}, Got {answer}");
            Assert.NotEqual(0, answer);
            Assert.Equal(expectedValue, answer);
        }
    }
}