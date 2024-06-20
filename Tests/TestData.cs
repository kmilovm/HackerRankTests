using System.Collections;
using MyTestsPresentedLib.Model;

namespace Tests
{
    public class TestData
    {
        public static IEnumerable<object[]> CombArrayTestData => new List<object[]>
        {
            new object[] { new[] { 1, 2, 3, 4, 5, 6 }, new[] { 6, 1, 2, 3, 4, 5 }, new[] { 1, 6 }, 1, 1 },
            new object[] { new[] { 1, 2, 3, 4, 5, 6 }, new[] { 5, 6, 1, 2, 3, 4 }, new[] { 1, 2, 5, 6 }, 2, 2 },
            new object[] { new[] { 1, 2, 3, 4, 5, 6 }, new[] { 4, 5, 6, 1, 2, 3 }, new[] { 1, 2, 3, 4, 5, 6 }, 3, 3 }
        };

        public static IEnumerable<object[]> IntTestData => new List<object[]>
        {
            new object[] { new[] { 1, 3, 6, 4, 1, 2 }, int.MaxValue },
            new object[] { new[] { 1, 2, 3 }, int.MaxValue },
            new object[] { new[] { -1, -3 }, int.MaxValue }
        };

        public static IEnumerable<object[]> TempFailData => new List<object[]>
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

        public static IEnumerable<object[]> TempTestData => new List<object[]>
        {
            new object[]
            {
                new[] { "1_300_1704743490", "1_400_1704757890", "2_200_1704743490", "2_300_1704757890" },
                new[] { "1", "2" }
            },
            new object[] { new[] { "1_300_1704743490", "2_200_1704743490" }, new[] { "1" } },
            new object[]
            {
                new[]
                {
                    "1_250_1704743490", "1_300_1704743700", "1_270_1704755000", "1_260_1704757000", "1_226_1704757890",
                    "2_300_1704743490", "2_400_1704743700", "2_380_1704755000", "2_330_1704757000", "2_281_1704757890"
                },
                new[] { "1", "2" }
            },
            new object[]
            {
                new[]
                {
                    "1_340_1704743490", "1_400_1704755000", "1_310_1704757890", "2_220_1704743490", "2_230_1704743700",
                    "2_260_1704755000", "2_290_1704757000", "2_250_1704757890"
                },
                new[] { "1", "2" }
            },
            new object[] { new[] { "1_300_1704743490" }, new[] { "1" } }
        };

        public static IEnumerable<object[]> TreeTestData => new List<object[]>
        {
            new object[]
            {
                new Tree()
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
                            RightTree = null
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
                },
                1,
                true,
                9
            },
            new object[]
            {
                new Tree()
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
                            RightTree = null
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
                },
                2,
                true,
                8
            },
            new object[]
            {
                new Tree()
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
                            RightTree = null
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
                },
                3,
                true,
                6
            },
            new object[]
            {
                new Tree()
                {
                    Value = 9,
                    LeftTree = new Tree
                    {
                        Value = 9,
                        LeftTree = new Tree
                        {
                            Value = 2,
                            LeftTree = null,
                            RightTree = null
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
                        Value = 5,
                        LeftTree = new Tree
                        {
                            Value = 9,
                            LeftTree = new Tree
                            {
                                Value = 9,
                                LeftTree = new Tree
                                {
                                    Value = 5,
                                    LeftTree = null,
                                    RightTree = new Tree
                                    {
                                        Value = 9,
                                        LeftTree = null,
                                        RightTree = null
                                    }
                                },
                                RightTree = new Tree
                                {
                                    Value = 9,
                                    LeftTree = null,
                                    RightTree = null
                                }
                            },
                            RightTree = null
                        },
                        RightTree = new Tree
                        {
                            Value = 9,
                            LeftTree = null,
                            RightTree = null
                        }
                    }
                },
                3,
                false,
                5
            },
            new object[]
            {
                new Tree()
                {
                    Value = 9,
                    LeftTree = new Tree
                    {
                        Value = 9,
                        LeftTree = new Tree
                        {
                            Value = 2,
                            LeftTree = null,
                            RightTree = null
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
                        Value = 5,
                        LeftTree = new Tree
                        {
                            Value = 9,
                            LeftTree = new Tree
                            {
                                Value = 9,
                                LeftTree = new Tree
                                {
                                    Value = 5,
                                    LeftTree = null,
                                    RightTree = new Tree
                                    {
                                        Value = 9,
                                        LeftTree = null,
                                        RightTree = null
                                    }
                                },
                                RightTree = new Tree
                                {
                                    Value = 9,
                                    LeftTree = null,
                                    RightTree = null
                                }
                            },
                            RightTree = null
                        },
                        RightTree = new Tree
                        {
                            Value = 9,
                            LeftTree = null,
                            RightTree = null
                        }
                    }
                },
                3,
                true,
                8
            }

        };

        public static IEnumerable<object[]> AddTwoSumsData => new List<object[]>()
        {
            new object[]
            {
                new ListNode()
                {
                    val = 2,
                    next = new ListNode()
                    {
                        val = 4,
                        next = new ListNode()
                        {
                            val = 3,
                            next = null
                        }
                    }
                },
                new ListNode()
                {
                    val = 5,
                    next = new ListNode()
                    {
                        val = 6,
                        next = new ListNode()
                        {
                            val = 4,
                            next = null
                        }
                    }
                },
                new ListNode()
                {
                    val = 7,
                    next = new ListNode()
                    {
                        val = 0,
                        next = new ListNode()
                        {
                            val = 8,
                            next = null
                        }
                    }
                }
            },
            new object[]
            {
                new ListNode()
                {
                    val = 0,
                    next = null
                },
                new ListNode()
                {
                    val = 0,
                    next = null
                },
                new ListNode()
                {
                    val = 0,
                    next = null
                },
            },
            new object[]
            {
                new ListNode()
                {
                    val = 9,
                    next = new ListNode()
                    {
                        val = 9,
                        next = new ListNode()
                        {
                            val = 9,
                            next = new ListNode()
                            {
                                val = 9,
                                next = new ListNode()
                                {
                                    val = 9,
                                    next = new ListNode()
                                    {
                                        val = 9,
                                        next = new ListNode()
                                        {
                                            val = 9,
                                            next = null
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ListNode()
                {
                    val = 9,
                    next = new ListNode()
                    {
                        val = 9,
                        next = new ListNode()
                        {
                            val = 9,
                            next = new ListNode()
                            {
                                val = 9,
                                next = null
                            }
                        }
                    }
                },
                new ListNode()
                {
                    val = 8,
                    next = new ListNode()
                    {
                        val = 9,
                        next = new ListNode()
                        {
                            val = 9,
                            next = new ListNode()
                            {
                                val = 9,
                                next = new ListNode()
                                {
                                    val = 0,
                                    next = new ListNode()
                                    {
                                        val = 0,
                                        next = new ListNode()
                                        {
                                            val = 0,
                                            next = new ListNode()
                                            {
                                                val = 1,
                                                next = null
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };

        public static IEnumerable<object[]> ReverseNodesData => new List<object[]>()
        {
            new object[]
            {
                new ListNode()
                {
                    val = 1,
                    next = new ListNode()
                    {
                        val = 2,
                        next = new ListNode()
                        {
                            val=3,
                            next = new ListNode()
                            {
                                val = 4,
                                next = new ListNode()
                                {
                                    val = 5,
                                    next = null
                                }
                            }
                        }
                    }

                },
                new ListNode()
                {
                    val = 2,
                    next = new ListNode()
                    {
                        val = 1,
                        next = new ListNode()
                        {
                            val = 4,
                            next = new ListNode()
                            {
                                val = 3,
                                next = new ListNode()
                                {
                                    val = 5,
                                    next = null
                                }
                            }
                        }
                    }

                },
                2
            },
            new object[]
            {
                new ListNode()
                {
                    val = 1,
                    next = new ListNode()
                    {
                        val = 2,
                        next = new ListNode()
                        {
                            val=3,
                            next = new ListNode()
                            {
                                val = 4,
                                next = new ListNode()
                                {
                                    val = 5,
                                    next = null
                                }
                            }
                        }
                    }
                    
                },
                new ListNode()
                {
                    val = 3,
                    next = new ListNode()
                    {
                        val = 2,
                        next = new ListNode()
                        {
                            val = 1,
                            next = new ListNode()
                            {
                                val = 4,
                                next = new ListNode()
                                {
                                    val = 5,
                                    next = null
                                }
                            }
                        }
                    }

                },
                3
            }
        };

        public static IEnumerable<object[]> QueensListData => new List<object[]>()
        {
            new object[]
            {
                4,
                new List<IList<string>>
                {
                    new List<string> { ".Q..", "...Q", "Q...", "..Q." },
                    new List<string> { "..Q.", "Q...", "...Q", ".Q.." }
                }
            }
        };
    }
}
