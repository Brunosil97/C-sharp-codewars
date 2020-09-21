using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace C_sharp_codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            kata.IsPangram("The quick brown fox jumps over the lazy dog.");
        }
    }

    public class Kata
    {
        //Find the number that is odd in even list and even number in odd list
        public  int Find(int[] integers)
        {
            var even = new List<int>();
            var odd = new List<int>();

            for(int i = 0; i < integers.Length; i++)
            {
                if(integers[i] % 2 == 0) { even.Add(integers[i]); }
                if(integers[i] % 2 == 1) { odd.Add(integers[i]);  }
            }

            if(even.Count > odd.Count) { return odd[0]; }
            else { return even[0]; }
        }

        //Check if string contains every letter in the alphabet
        public bool IsPangram(string sentence)
        {
            return sentence.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26;
        }
    }
}
