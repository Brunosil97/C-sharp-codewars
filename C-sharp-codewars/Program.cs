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
            //Console.WriteLine(kata.DuplicateCount(""));
            //Console.WriteLine(kata.DuplicateCount("abcde"));
            //Console.WriteLine(kata.DuplicateCount("aabbcde"));
            //Console.WriteLine(kata.DuplicateCount("aabBcde"));
            Console.WriteLine(kata.DuplicateCount("Indivisibility"));
            Console.WriteLine(kata.SongDecoder("ISWUBWUBABCWUB"));
            Console.WriteLine(kata.FirstNonRepeat("stress"));


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

        //Count duplicate letters in string
        public int DuplicateCount(string setence)
        {
            var charList = new List<char>();
            var dupList = new List<char>();

            if(!string.IsNullOrEmpty(setence))
            {
                foreach(char ch in setence.ToLower())
                {
                    if(!charList.Contains(ch))
                    {
                        charList.Add(ch);
                    }
                    else { dupList.Add(ch);  }
                }
            }
            return dupList.Distinct().Count(); ;
        }

        //Dubstup song - replace dubstep WUB in song inputs
        public string SongDecoder(string input)
        {
            string song = input.Replace("WUB", " ").Trim();
            song = Regex.Replace(song, @"\s+", " ");

            return song;
        }

        //Return the first non repeating character in a string
        public char FirstNonRepeat(string str)
        {
            int i, j;
            bool isRepeated = false;
            char[] chars = str.ToCharArray();

            for(i = 0; i < chars.Length; i++)
            {
                isRepeated = false;
                for(j = 0; j < chars.Length; j++)
                {
                    if((i != j) && (chars[i] == chars[j]))
                    {
                        isRepeated = true;
                        break;
                    }
                }
                if(isRepeated == false)
                {
                    return str[i];
                }
            }
            return ' ';        
        }

        //Return the names of who likes the post from string array
        public string WhoLikedIt(string[] name)
        {
            if (name.Length == 1) { return $"{name[0]} likes this"; }
            else if(name.Length == 2) { return $"{name[0]} and {name[1]} like this"; }
            else if(name.Length == 3) { return $"{name[0]}, {name[1]} and {name[2]} like this"; }
            else if(name.Length == 4) { return $"{name[0]}, {name[1]} and 2 others like this"; }
            else if (name.Length > 4) { return $"{name[0]}, {name[1]} and {name.Length - 2} others like this"; }
            else { return "no one likes this";  }
        }
    }
}
