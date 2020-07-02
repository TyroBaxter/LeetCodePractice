using LeetCode.Code;
using LeetCode.Code.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests
{
    [TestClass]
    public class Prob884Test
    {
        [TestMethod]
        public void It_should_return_apple()
        {
            var p = new Prob884();

            var result = p.UncommonFromSentences(
                "the apple is sweet",
                "the apple is sour"
                );
            CollectionAssert.AreEquivalent(new[] { "sweet", "sour" }, result);
                                   
        }

        [TestMethod]
        public void It_should_return_banana()
        {
            var p = new Prob884();

            var result = p.UncommonFromSentences("apple apple", "banana");

            CollectionAssert.AreEquivalent(new[] { "banana" }, result);
        }
    }
}
