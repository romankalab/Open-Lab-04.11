using System;
using System.Collections.Generic;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            string solution = String.Empty;
            var charlist = new List<char>(str.ToCharArray());
            charlist.Sort();
            for (var x = 0; x < charlist.Count; x++)
                solution = solution + charlist[x];
            return solution;

        }
    }
}
