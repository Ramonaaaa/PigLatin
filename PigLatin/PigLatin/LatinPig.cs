using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    public static class LatinPig
    {
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        public static string TransformWord(string input)
        {
            if (input.Length > 0)
            {
                if (Array.IndexOf(vowels, char.ToLower(input[0])) >= 0)
                {
                    return input + "ay";
                }
                else
                {
                    return input.Substring(1) + input.Substring(0, 1).ToLower() + "ay";
                }                             
            }
            return "";
        }
    }
}
