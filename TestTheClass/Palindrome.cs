using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTheClass
{
    public static class Palindrome
    {

        public static void checkPalindrome()
        {
            Console.WriteLine(IsPalindrome("abcdef"));
        }

        //abcd
        //0123
        private static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
