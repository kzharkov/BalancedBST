using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures2;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;

namespace BalancedBSTTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //        5 
            //      /  \
            //     2    7
            //    / \  / \
            //   1  3 6   8

            var arr = new[]
            {
                5,
                3,
                7,
                1,
                2,
                6,
                8
            };

            var expected = new[]
            {
                5, 2, 7, 1, 3, 6, 8
            };

            var actual = BalancedBST.GenerateBBSTArray(arr);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OnlyRoot()
        {
            var arr = new[] {5};

            var expected = new[] {5};
            
            var actual = BalancedBST.GenerateBBSTArray(arr);

            CollectionAssert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Depth1()
        {
            var arr = new[] {5, 9, 1};

            var expected = new[] {5, 1, 9};
            
            var actual = BalancedBST.GenerateBBSTArray(arr);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}