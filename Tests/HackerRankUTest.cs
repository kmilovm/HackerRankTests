using System.Reflection;
using AutoFixture;
using HackerRankLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Xunit.Abstractions;

namespace Tests
{
    public class HackerRankUTest
    {
        public readonly IHackerRankLib _hackerRankLib;
        public readonly ITestOutputHelper _testOutputHelper;
        public readonly IServiceCollection _svcCollection;
        public readonly Fixture _fixture;

        public HackerRankUTest(ITestOutputHelper testOutputHelper, IServiceCollection svcCollection)
        {
            _hackerRankLib = new HackerRankLibrary();
            _testOutputHelper = testOutputHelper;
            _svcCollection = new ServiceCollection();
            _fixture = new Fixture();
        }
        
        [Theory]
        [InlineData(12345)]
        public void IsPalindrome_Failure(int number)
        {
            var answer = HackerRankUTestsHelper.IsPalindrome(_hackerRankLib,number);
            Assert.False(answer);
        }

        [Theory]
        [InlineData(12321)]
        public void IsPalindrome_Success(int number)
        {
            var answer = HackerRankUTestsHelper.IsPalindrome(_hackerRankLib, number);
            Assert.True(answer);
        }

        [Fact]
        public void MiniMaxSum_Success()
        {
            var numbers = _fixture.CreateMany<long>(5);
            var answer = HackerRankUTestsHelper.MiniMaxSum(_hackerRankLib,numbers.ToList());
            _testOutputHelper.WriteLine(string.Join(',', numbers.ToList()));
            _testOutputHelper.WriteLine(answer);
            Assert.NotEmpty(answer);
        }
        
        [Theory]
        [InlineData(5)]

        public void StairCase_Success(int number)
        {
            var answer = HackerRankUTestsHelper.StairCase(_hackerRankLib,number);
            _testOutputHelper.WriteLine(answer);
            Assert.NotEmpty(answer);
        }

        [Fact]
        
        public void BetterCompression_Success()
        {
            const string original = "a2b3c4a5b4c3d7";
            const string expected = "a7b7c7d7";
            var answer = HackerRankUTestsHelper.BetterCompression(_hackerRankLib, original);
            _testOutputHelper.WriteLine(answer);
            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData(25,9)]
        
        public void PossibleTwoSums_Failure(int target, int arrayLength)
        {
            var answer = HackerRankUTestsHelper.PossibleTwoSums(_hackerRankLib, target, arrayLength);
            _testOutputHelper.WriteLine(answer);
            Assert.Empty(answer);
        }
        [Theory]
        [InlineData(13, 9)]

        public void PossibleTwoSums_Success(int target, int arrayLength)
        {
            var answer = HackerRankUTestsHelper.PossibleTwoSums(_hackerRankLib, target, arrayLength);
            _testOutputHelper.WriteLine(answer);
            Assert.NotEmpty(answer);
        }

        [Fact]
        
        public void GetAssemblies()
        {
            var answer = HackerRankUTestsHelper.GetAssemblies(_hackerRankLib, Assembly.GetExecutingAssembly(), "Microsoft");
            var selTyp = answer.FirstOrDefault(tp => tp.Name.Equals(""));
            if (selTyp != null) _svcCollection.TryAddSingleton(selTyp);
            Assert.NotEmpty(answer);
        }
    }
}