using System;

namespace StringPermutation.Data
{
    public class StringPermutationService : IStringPermutationService
    {
        public string Description => "Checks if any permutation of a string is the same read from the beginning or the end. Spaces are ignored, the tool is case insensitive.";

        /// <summary>
        /// Even pairs of the same character allow for rearrangment to produce a palindrome. More than one odd character count disqualifies such a rearrangement.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool HasValidPermutation(string s)
        {
            string formattedInput = RemoveSpacesAndMakeLowerCase(s);
            int[] _charCount = ProcessStringByCountingChars(formattedInput);
            return HasNoMoreThanOneOddEntry(_charCount);
        }

        private string RemoveSpacesAndMakeLowerCase(string s)
        {
            return s.Replace(" ", "").ToLower();
        }

        private int[] ProcessStringByCountingChars(string s)
        {
            int ASCII_CHARACTER_COUNT = 256;
            
            int[] result = new int[ASCII_CHARACTER_COUNT];
            
            Array.Fill(result, 0);
            
            for (int i = 0; i < s.Length; i++)
            {
                result[s[i]]++;
            }

            return result;
        }

        private bool HasNoMoreThanOneOddEntry(int[] array)
        {
            int oddEntries = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                    oddEntries++;

                if (oddEntries > 1)
                    return false;
            }

            return true;
        }
    }
}