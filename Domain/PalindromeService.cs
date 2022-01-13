using System;
using System.Linq;

namespace StringPermutation.Data
{
    public class PalindromeService : IStringPermutationService
    {
        public string Description => "Checks if a string is a palindrome";

        public bool HasValidPermutation(string s)
        {
            string _reverseString = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                _reverseString += s[i].ToString();
            }
            return _reverseString == s;
        }
    }
}
