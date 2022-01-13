using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringPermutation.Data;

namespace Testing
{
    [TestClass]
    public class PalendromeServiceTests
    {
        [DataTestMethod]
        [DataRow("dad", true)]
        [DataRow("Dad", true)]
        [DataRow("abc", false)]
        [DataRow("rotor", true)]
        [DataRow("", true)]
        [DataRow("123321", true)]
        [DataRow("951234", false)]
        [DataRow("?£%ee%£?", true)]
        public void CheckIfPalindrome(string input, bool expectedOutput)
        {
            IStringPermutationService service = new PalindromeService();
            bool result = service.HasValidPermutation(input);
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
