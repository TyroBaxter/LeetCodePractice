using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests
{
    [TestClass]
    public class Prob1342Test
    {
        [TestMethod]
        public void It_Should_Return_True_With_4()
        {
            Prob1342 p = new Prob1342();

            Assert.IsTrue(p.IsPowerOfFour(4));
        }

        [TestMethod]
        public void It_Should_Return_True_With_16()
        {
            Prob1342 p = new Prob1342();
            Assert.IsTrue(p.IsPowerOfFour(16));
        }

        [TestMethod]
        public void It_Should_Return_True_With_65536()
        {
            Prob1342 p = new Prob1342();
            Assert.IsTrue(p.IsPowerOfFour(65536));
        }

        [TestMethod]
        public void It_Should_Return_False_With_5()
        {
            Prob1342 p = new Prob1342();
            Assert.IsTrue(p.IsPowerOfFour(5));
        }

        [TestMethod]
        public void It_Should_Return_False_With_0()
        {
            Prob1342 p = new Prob1342();
            Assert.IsTrue(p.IsPowerOfFour(0));
        }

        [TestMethod]
        public void It_Should_Return_False_With_Negative_4()
        {
            Prob1342 p = new Prob1342();
            Assert.IsTrue(p.IsPowerOfFour(-4));
        }
    }
}
