using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringPermutation.Data;

namespace Testing
{
    [TestClass]
    public class StringPermutationServiceTests
    {
        [DataTestMethod]
        [DataRow("Pot spot", true)]
        [DataRow("Potspot", true)]
        [DataRow("ab", false)]
        [DataRow("aabbccddeeffghhiijj", true)]
        [DataRow("aa, bb", true)]
        [DataRow("aa, bb,", true)]
        [DataRow("aa, bb, cc, d", false)]
        public void CheckIfPermutation(string input, bool expectedOutput)
        {
            IStringPermutationService service = new StringPermutationService();
            bool result = service.HasValidPermutation(input);
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
