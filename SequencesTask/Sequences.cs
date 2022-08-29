using System;
using System.Collections.Generic;

#pragma warning disable S1643
#pragma warning disable S2259

namespace SequencesTask
{
    public static class Sequences
    {
        /// <summary>
        /// Find all the contiguous substrings of length length in given string of digits in the order that they appear.
        /// </summary>
        /// <param name="numbers">Source string.</param>
        /// <param name="length">Length of substring.</param>
        /// <returns>All the contiguous substrings of length n in that string in the order that they appear.</returns>
        /// <exception cref="ArgumentException">
        /// Throw if length of substring less and equals zero
        /// -or-
        /// more than length of source string
        /// - or-
        /// source string containing a non-digit character
        /// - or
        /// source string is null or empty or white space.
        /// </exception>
        public static string[] GetSubstrings(string numbers, int length)
        {
            List<string> res = new List<string>();
            if (length <= 0)
            {
                throw new ArgumentException($"{length}");
            }

            if (string.IsNullOrWhiteSpace(numbers) || numbers.Length == 0)
            {
                throw new ArgumentException($"{numbers}");
            }

            if (numbers.Length < length)
            {
                throw new ArgumentException($"{length}");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (char.IsLetter(numbers[i]))
                {
                    throw new ArgumentException($"{numbers}");
                }
            }

            string temp = null;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < length + i && j < numbers.Length; j++)
                {
                     temp += numbers[j].ToString();
                }

                if (temp.Length == length)
                {
                    res.Add(temp);
                }

                temp = null;
            }

            return res.ToArray();
        }
    }
}
