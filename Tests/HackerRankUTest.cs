using AutoFixture;
using HackerRankLib;
using HackerRankLib.Model;
using System.Linq;
using Xunit.Abstractions;

namespace Tests
{
    public class HackerRankUTest
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly Fixture _fixture;

        public HackerRankUTest(ITestOutputHelper testOutputHelper)
        {
            HackerRankLibHelper.Initialize(new HackerRankLibrary());
            _testOutputHelper = testOutputHelper;
            _fixture = new Fixture();
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
        [InlineData(5)]

        public void StairCaseSuccess(int number)
        {
            var answer = HackerRankLibHelper.StairCase(number);
            _testOutputHelper.WriteLine(answer);
            Assert.NotEmpty(answer);
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
        [InlineData(25,9)]
        
        public void PossibleTwoSumsFailure(int target, int arrayLength)
        {
            var answer = HackerRankLibHelper.PossibleTwoSums( target, arrayLength);
            _testOutputHelper.WriteLine(answer);
            Assert.Empty(answer);
        }
        [Theory]
        [InlineData(13, 9)]

        public void PossibleTwoSumsSuccess(int target, int arrayLength)
        {
            var answer = HackerRankLibHelper.PossibleTwoSums( target, arrayLength);
            _testOutputHelper.WriteLine(answer);
            Assert.NotEmpty(answer);
        }

        [Theory]
        [InlineData(3)]
        public void PossibleSuccessiveNumbers(int numberOfSuccessiveNumbers)
        {
            var testTree = new Tree()
            {
                Value = 1,
                LeftTree = new Tree
                {
                    Value = 2,
                    LeftTree = new Tree
                    {
                        Value = 5,
                        LeftTree = new Tree
                        {
                            Value = 3,
                            LeftTree = null,
                            RightTree = null
                        },
                        RightTree= null
                    },
                    RightTree = new Tree
                    {
                        Value = 9,
                        LeftTree = null,
                        RightTree = null
                    }
                },
                RightTree = new Tree
                {
                    Value = 7,
                    LeftTree = new Tree
                    {
                        Value = 4,
                        LeftTree = null,
                        RightTree = new Tree
                        {
                            Value = 0,
                            LeftTree = null,
                            RightTree = null
                        }
                    },
                    RightTree = new Tree
                    {
                        Value = 8,
                        LeftTree = null,
                        RightTree = null
                    }
                }
            };
            var answer = HackerRankLibHelper.PossibleSuccessiveCombinations(testTree, numberOfSuccessiveNumbers);
            _testOutputHelper.WriteLine(answer.Item1);
            _testOutputHelper.WriteLine(answer.Item2.ToString());
            Assert.NotEmpty(answer.ToString());
        }
    }
}