using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestTheClass
{
    public static class ReverseTheString
    {
        public static string Reverse(string word)
        {
            StringBuilder sb = new StringBuilder();
            string bc = "";

            foreach(char c in word)
            {
                //Create a new string in reverse
                bc = c + bc;
            }

            return bc;
        }
    }
}
