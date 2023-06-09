using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Martin_Extend_A_String
{
    public static class StringExtensions
    {
        public static bool IsPalindrome(this string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                    if (input[i].ToString() != input[input.Length - 1 - i].ToString())
                    {
                        return false;
                    }
            }
            return true;
        }
        public static bool IsPalindrome(this string input, bool caseSensitive)
        {
            if (!caseSensitive)
            {
                input = input.ToLower();
            }

            return input.IsPalindrome();
        }
        public static string ReverseString(this string input)
        {
            Char[] chars = input.ToCharArray();
            Array.Reverse(chars);

            //OLD CODE
            //for (int i = 0; i < chars.Length / 2; i++)
            //{
            //    char temp = chars[i];
            //    chars[i] = chars[chars.Length - 1 - i];
            //    chars[chars.Length - 1 - i] = temp;
            //}
            //string str = new string(chars);

            return new string (chars);
        }
        public static string ReverseString(this string input, bool caseStays)
        {
            if (caseStays)
            {
                List<int> capitalIndexes = input
                    .Select((c, index) => new { Char = c, Index = index })
                    .Where(x => char.IsUpper(x.Char))
                    .Select(x => x.Index)
                    .ToList();

                Char[] charinput = input.ToLower().ToCharArray();
                Array.Reverse (charinput);
                for (int i = 0; i < capitalIndexes.Count; i++)
                {
                    charinput[capitalIndexes[i]] = Convert.ToChar(charinput[capitalIndexes[i]].ToString().ToUpper());
                }

                return new string(charinput);
            }
            else
            {
                return input.ReverseString();
            }
        }
        public static string RemoveDuplicates(this string input)
        {
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (!result.Contains(input[i]))
                {
                    result += input[i];
                }
            }
            return result;
        }
        public static int CountOccurrences(this string input, char pattern)
        {
            return input.Count(c => c == pattern);
        }
        public static int CountOccurrences(this string input, string pattern)
        {
            int count = 0;

            foreach(Match m in Regex.Matches(input, pattern)){
                count++;
            }

            if(count == 0)
            {
                return -1;
            }
            else
            {
                return count;
            }
        }
        public static int CountOccurrences(this string input, OccurrenceType OT)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char lowerC = char.ToLower(c);
                    if (charCounts.ContainsKey(lowerC))
                    {
                        charCounts[lowerC]++;
                    }
                    else
                    {
                        charCounts[lowerC] = 1;
                    }
                }
            }

            if (OT == OccurrenceType.MaxOccurrence)
            {
                return charCounts.Values.Max();
            }
            else if (OT == OccurrenceType.MinOccurrence)
            {
                return charCounts.Values.Min();
            }
            else if (OT == OccurrenceType.MaxOccurrenceVowels)
            {
                return GetVowelCount(charCounts, true);
            }
            else
            {
                return GetVowelCount(charCounts, false);
            }
        }
        private static int GetVowelCount(Dictionary<char, int> charCounts, bool isMax)
        {
            int vowelCount = isMax ? 0 : int.MaxValue;
            foreach (char vowel in "aeiou")
            {
                if (charCounts.ContainsKey(vowel))
                {
                    if (isMax)
                    {
                        vowelCount = Math.Max(vowelCount, charCounts[vowel]);
                    }
                    else
                    {
                        vowelCount = Math.Min(vowelCount, charCounts[vowel]);
                    }
                }
            }
            return vowelCount;
        }
    }
}
