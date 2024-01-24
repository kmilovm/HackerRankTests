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

        public static IEnumerable<object[]> TreeTestData =>
            new List<object[]>
            {
                new object[] { new Tree() { Value = 1, LeftTree = new Tree { Value = 2, LeftTree = new Tree { Value = 5, LeftTree = new Tree { Value = 3, LeftTree = null, RightTree = null }, RightTree = null }, RightTree = new Tree { Value = 9, LeftTree = null, RightTree = null } }, RightTree = new Tree { Value = 7, LeftTree = new Tree { Value = 4, LeftTree = null, RightTree = new Tree { Value = 0, LeftTree = null, RightTree = null } }, RightTree = new Tree { Value = 8, LeftTree = null, RightTree = null } } }, 1 },
                new object[] { new Tree() { Value = 1, LeftTree = new Tree { Value = 2, LeftTree = new Tree { Value = 5, LeftTree = new Tree { Value = 3, LeftTree = null, RightTree = null }, RightTree = null }, RightTree = new Tree { Value = 9, LeftTree = null, RightTree = null } }, RightTree = new Tree { Value = 7, LeftTree = new Tree { Value = 4, LeftTree = null, RightTree = new Tree { Value = 0, LeftTree = null, RightTree = null } }, RightTree = new Tree { Value = 8, LeftTree = null, RightTree = null } } }, 2 },
                new object[] { new Tree() { Value = 1, LeftTree = new Tree { Value = 2, LeftTree = new Tree { Value = 5, LeftTree = new Tree { Value = 3, LeftTree = null, RightTree = null }, RightTree = null }, RightTree = new Tree { Value = 9, LeftTree = null, RightTree = null } }, RightTree = new Tree { Value = 7, LeftTree = new Tree { Value = 4, LeftTree = null, RightTree = new Tree { Value = 0, LeftTree = null, RightTree = null } }, RightTree = new Tree { Value = 8, LeftTree = null, RightTree = null } } }, 3 },
            };

        public static IEnumerable<object[]> IntTestData =>
            new List<object[]>
            {
                new object[] { new[] { 1, 3, 6, 4, 1, 2 }, int.MaxValue },
                new object[] { new[] { 1, 2, 3 }, int.MaxValue },
                new object[] { new[] { -1, -3 }, int.MaxValue },
            };

        public static IEnumerable<object[]> TempTestData =>
            new List<object[]>
            {
                new object[] { new[] { "1_300_1704743490", "1_400_1704757890", "2_200_1704743490", "2_300_1704757890" }, new [] {"1", "2"} },
                new object[] { new[] { "1_300_1704743490", "2_200_1704743490" }, new [] {"1"} },
                new object[] { new[] { "1_400_1704757890", "1_300_1704743490", "1_400_1704757890", "2_200_1704743490", "2_300_1704757890" }, new [] {"1", "2"} },
                new object[] { new[] { "1_250_1704743490", "1_300_1704743700", "1_270_1704755000", "1_260_1704757000", "1_226_1704757890", "2_300_1704743490", "2_400_1704743700", "2_380_1704755000", "2_330_1704757000", "2_281_1704757890" }, new [] {"1", "2"} },
                new object[] { new[] { "1_340_1704743490", "1_400_1704755000", "1_310_1704757890", "2_220_1704743490", "2_230_1704743700", "2_260_1704755000", "2_290_1704757000", "2_250_1704757890" }, new [] {"1", "2"} },
                new object[] { new[] { "1_300_1704743490" }, new [] {"1"} }
            };

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
        [MemberData(nameof(TreeTestData))]
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
        [MemberData(nameof(IntTestData))]

        public void FindSmallestPositiveNumber(int[] baseNumbers, int maxValue)
        {
            var answer = HackerRankLibHelper.FindSmallestPositiveInteger(baseNumbers, maxValue);
            _testOutputHelper.WriteLine(string.Join(",",baseNumbers));
            _testOutputHelper.WriteLine(answer.ToString());
            Assert.NotEqual(-1,answer);
        }

        [Theory]
        [MemberData(nameof(TempTestData))]

        public void GetAverageTemperatureFromSensors(string[] dataPoints, string[] sensors)
        {
            var answer = HackerRankLibHelper.GetAverageTemperatureFromSensors(dataPoints, sensors);
            _testOutputHelper.WriteLine(answer.ToString());
            Assert.NotEqual(-1, answer);
            Assert.Equal(300, answer);
        }
    }
}