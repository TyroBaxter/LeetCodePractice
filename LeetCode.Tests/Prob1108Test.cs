using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests
{
    [TestClass]
    public class Prob1108Test
    {

        [TestMethod]
        public void It_should_return_a_defanged_IP_of_repeating_numbers()
        {
            var p = new Prob1108();

            var result = p.DefangIPaddr("1.1.1.1");
            Assert.AreEqual("1[.]1[.]1[.]1", result);

        }

        [TestMethod]
        public void It_should_return_a_defanged_IP_address_of_nonrepeating_numbers()
        {
            var p = new Prob1108();

            var result = p.DefangIPaddr("255.100.50.0");
            Assert.AreEqual("255[.]100[.]50[.]0", result);
        }
    }
}
