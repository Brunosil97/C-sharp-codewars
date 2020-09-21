using System;
using System.Collections.Generic;

namespace C_sharp_codewars
{
    class Program
    {
        static void Main(string[] args)
        {
         
        }
    }

    public class Kata
    {
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
    }
}
