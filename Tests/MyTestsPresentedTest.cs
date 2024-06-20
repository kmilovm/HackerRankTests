using AutoFixture;
using MyTestsPresentedLib;
using MyTestsPresentedLib.Model;
using Xunit.Abstractions;

namespace Tests
{
    public class MyTestsPresentedUTest
    {
        private readonly Fixture _fixture;
        private readonly ITestOutputHelper _testOutputHelper;
        public MyTestsPresentedUTest(ITestOutputHelper testOutputHelper)
        {
            MyTestsPresentedLibHelper.Initialize(new MyTestsPresentedLibrary());
            _testOutputHelper = testOutputHelper;
            _fixture = new Fixture();
        }



        [Theory]
        [MemberData(nameof(TestData.AddTwoSumsData), MemberType = typeof(TestData))]
        public void AddTwoSums(ListNode list1, ListNode list2, ListNode expected)
        {
            var answer = MyTestsPresentedLibHelper.AddTwoNumbers(list1, list2);
            _testOutputHelper.WriteLine($"Expected: {string.Join(",", expected)}, Got {string.Join(",", answer)}");
            Assert.NotNull(answer);
            Assert.Equivalent(expected, answer);
        }

        [Fact]

        public void BetterCompressionSuccess()
        {
            const string original = "a2b3c4a5b4c3d7";
            const string expected = "a7b7c7d7";
            var answer = MyTestsPresentedLibHelper.BetterCompression(original);
            _testOutputHelper.WriteLine(answer);
            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 5 }, new[] { "1,1", "1,2", "1,5", "2,1", "2,2", "2,5", "5,1", "5,2", "5,5" })]
        public void BuildCartesianProduct(int[] arrayA, string[] expected)
        {
            var answer = MyTestsPresentedLibHelper.BuildCartesianProduct(arrayA);
            _testOutputHelper.WriteLine($"Expected: {expected}, Got {answer}");
            Assert.NotNull(answer);
            Assert.Equal(expected, answer.ToArray());
        }

        [Theory]
        [MemberData(nameof(TestData.CombArrayTestData), MemberType = typeof(TestData))]

        public void CombineArrays(int[] arrayA, int[] arrayB, int[] expected, int takeFromA, int takeFromB)
        {
            var answer = MyTestsPresentedLibHelper.CombineArrays(arrayA, arrayB, takeFromA, takeFromB);
            _testOutputHelper.WriteLine($"Expected: {expected}, Got {answer}");
            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 6, 1, 2, 3, 4, 5 }, 1)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 5, 6, 1, 2, 3, 4 }, 2)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 4, 5, 6, 1, 2, 3 }, 3)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 3, 4, 5, 6, 1, 2 }, 4)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 2, 3, 4, 5, 6, 1 }, 5)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 1, 2, 3, 4, 5, 6 }, 6)]

        public void CycleRotation(int[] numbers, int[] expected, int rotations)
        {
            var answer = MyTestsPresentedLibHelper.CyclicRotation(numbers, rotations);
            _testOutputHelper.WriteLine($"Expected: {expected}, Got {answer}");
            Assert.Equal(expected, answer);
        }

        [Theory]
        [MemberData(nameof(TestData.IntTestData), MemberType = typeof(TestData))]

        public void FindSmallestPositiveNumber(int[] baseNumbers, int maxValue)
        {
            var answer = MyTestsPresentedLibHelper.FindSmallestPositiveInteger(baseNumbers, maxValue);
            _testOutputHelper.WriteLine(string.Join(",", baseNumbers));
            _testOutputHelper.WriteLine(answer.ToString());
            Assert.NotEqual(-1, answer);
        }

        [Theory]
        [MemberData(nameof(TestData.TempTestData), MemberType = typeof(TestData))]

        public void GetAverageTemperatureFromSensors(string[] dataPoints, string[] sensors)
        {
            const int expectedValue = 300;
            var answer = MyTestsPresentedLibHelper.GetAverageTemperatureFromSensors(dataPoints, sensors);
            _testOutputHelper.WriteLine($"Expected: {expectedValue}, Got {answer}");
            Assert.NotEqual(-1, answer);
            Assert.Equal(expectedValue, answer);
        }

        [Theory]
        [InlineData(12345)]
        public void IsPalindromeFailure(int number)
        {
            var answer = MyTestsPresentedLibHelper.IsPalindrome(number);
            Assert.False(answer);
        }

        [Theory]
        [InlineData(12321)]
        public void IsPalindromeSuccess(int number)
        {
            var answer = MyTestsPresentedLibHelper.IsPalindrome( number);
            Assert.True(answer);
        }

        [Theory]
        [InlineData(new[] { 32, 9, 529, 20, 15, 1041 })]

        public void MaxBinaryGaps(int[] numbers)
        {
            const int expectedValue = 5;
            var answer = MyTestsPresentedLibHelper.MaxBinaryGaps(numbers);
            _testOutputHelper.WriteLine($"Expected: {expectedValue}, Got {answer}");
            Assert.NotEqual(0, answer);
            Assert.Equal(expectedValue, answer);
        }

        [Fact]
        public void MiniMaxSumSuccess()
        {
            var numbers = _fixture.CreateMany<long>(5);
            var enumerable = numbers as long[] ?? numbers.ToArray();
            var answer = MyTestsPresentedLibHelper.MiniMaxSum(enumerable.ToList());
            _testOutputHelper.WriteLine(string.Join(',', enumerable.ToList()));
            _testOutputHelper.WriteLine(answer);
            Assert.NotEmpty(answer);
        }

        [Theory]
        [MemberData(nameof(TestData.TreeTestData), MemberType = typeof(TestData))]
        public void PossibleSuccessiveNumbers(Tree treeData, int numberOfSuccessiveNumbers, bool allowDuplicates, int expectedItems)
        {
            var answer = MyTestsPresentedLibHelper.PossibleSuccessiveCombinations(treeData, numberOfSuccessiveNumbers, allowDuplicates);
            _testOutputHelper.WriteLine(answer.Item1);
            _testOutputHelper.WriteLine(answer.Item2.ToString());
            Assert.Equal(answer.Item2, expectedItems);
            Assert.NotEmpty(answer.ToString());
        }

        [Theory]
        [InlineData(25, 9)]

        public void PossibleTwoSumsFailure(int target, int arrayLength)
        {
            var answer = MyTestsPresentedLibHelper.PossibleTwoSums(target, arrayLength);
            _testOutputHelper.WriteLine(answer);
            Assert.Empty(answer);
        }

        [Theory]
        [InlineData(13, 9)]

        public void PossibleTwoSumsSuccess(int target, int arrayLength)
        {
            var answer = MyTestsPresentedLibHelper.PossibleTwoSums(target, arrayLength);
            _testOutputHelper.WriteLine(answer);
            Assert.NotEmpty(answer);
        }

        [Theory]
        [MemberData(nameof(TestData.ReverseNodesData), MemberType = typeof(TestData))]
        public void ReverseNodes(ListNode list1, ListNode expected, int idx)
        {
            var answer = MyTestsPresentedLibHelper.ReverseNodesInIndex(list1, idx);
            _testOutputHelper.WriteLine($"Expected: {string.Join(",", expected)}, Got {string.Join(",", answer)}");
            Assert.NotNull(answer);
            Assert.Equivalent(expected, answer);
        }

        [Theory]
        [InlineData(5)]

        public void StairCaseSuccess(int number)
        {
            var answer = MyTestsPresentedLibHelper.StairCase(number);
            _testOutputHelper.WriteLine(answer);
            Assert.NotEmpty(answer);
        }
        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, new[] { 0, 1 }, 9)]
        [InlineData(new[] { 3, 2, 4 }, new[] { 1, 2 }, 6)]
        [InlineData(new[] { 3, 3 }, new[] { 0, 1 }, 6)]
        [InlineData(new[] { 2, 7, 9, -12, 15 }, new[] { 0, 4 }, 17)]
        public void TwoSums(int[] numbers, int[] expected, int target)
        {
            var answer = MyTestsPresentedLibHelper.TwoSum(numbers, target);
            _testOutputHelper.WriteLine($"Expected: {string.Join(",", expected)}, Got {string.Join(",", answer)}");
            Assert.NotNull(answer);
            Assert.Equal(expected, answer);
        }
        [Theory]
        [MemberData(nameof(TestData.QueensListData), MemberType = typeof(TestData))]
        public void SolveNQueens(int numberOfQueens, IList<IList<string>> expected)
        {
            var answer = MyTestsPresentedLibHelper.SolveNQueens(numberOfQueens);
            _testOutputHelper.WriteLine($"Expected: {string.Join(", ", expected)}, Got {string.Join(", ", answer)}");
            Assert.NotNull(answer);
            Assert.Equal(expected, answer);
        }
    }
}