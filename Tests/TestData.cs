using HackerRankLib.Model;

namespace Tests
{
    public class TestData
    {
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
                new object[] { new[] { "1_250_1704743490", "1_300_1704743700", "1_270_1704755000", "1_260_1704757000", "1_226_1704757890", "2_300_1704743490", "2_400_1704743700", "2_380_1704755000", "2_330_1704757000", "2_281_1704757890" }, new [] {"1", "2"} },
                new object[] { new[] { "1_340_1704743490", "1_400_1704755000", "1_310_1704757890", "2_220_1704743490", "2_230_1704743700", "2_260_1704755000", "2_290_1704757000", "2_250_1704757890" }, new [] {"1", "2"} },
                new object[] { new[] { "1_300_1704743490" }, new [] {"1"} }
            };

        public static IEnumerable<object[]> TempFailData =>
            new List<object[]>
            {
                new object[]
                {
                    new[]
                    {
                        "1_400_1704757890", "1_300_1704743490", "1_400_1704757890", "2_200_1704743490",
                        "2_300_1704757890"
                    },
                    new[] { "1", "2" }
                }
            };
    }
}
