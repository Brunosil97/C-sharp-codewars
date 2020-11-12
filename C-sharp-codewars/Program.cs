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

        //Return true or false if the valid braces are in string
        public bool ValidBraces(string braces)
        {
            while(braces.IndexOf("{}") != -1 || braces.IndexOf("()") != -1 || braces.IndexOf("[]") != -1)
            {
                braces = braces.Replace("{}", "").Replace("[]", "").Replace("()", "");
            }

            return braces.Length == 0;
        }
        
        //convert the year given into the century
        public string WhatCentury(string year)
        {

            string century;
            century = ((int.Parse(year) + 99) / 100).ToString();
    
            var centuryArr = century.ToCharArray();
    
            if(centuryArr[0] == '1') {century = century + "th";}
            else if(centuryArr[1] == '1') {century = century + "st";}
            else if(centuryArr[1] == '2') {century = century + "nd";}
            else if(centuryArr[1] == '3') {century = century + "rd";}
            else { century = century + "th"; };

            return century;
        }
    }
    
    //Make a snake and ladders game
     class SnakesLadders
    {
      
      private int[] playerSquare = new int[2] { 0, 0};
      private int player = 0;
      private bool won = false;
      private int[,] trap = new int[21,2] {
        {2, 38},
        {7, 14},
        {8, 31},
        {15, 26},
        {21, 42},
        {28, 84},
        {36, 44},
        {51, 67},
        {71, 91},
        {78, 98},
        {87, 94},
        {16, 6},
        {46, 25},
        {49, 11},
        {62, 19},
        {64, 60},
        {74, 53},
        {89, 68},
        {92, 88},
        {95, 75},
        {99, 80}
      };
      
        public string play (int die1, int die2)
        {
            if (won) { return "Game over!"; }
            int roll = die1 + die2;
            if (roll + playerSquare[player] <= 100)
            {
                playerSquare[player] += roll;
                if (playerSquare[player] == 100) { won = true; return "Player " + (player + 1).ToString() + " Wins!"; }
            }
            else
            {
                playerSquare[player] = 100 - ((playerSquare[player] + roll) - 100);
            }
            for (int t = 0; t < trap.Length / 2; t++)
            {
                if (playerSquare[player] == trap[t,0]) { playerSquare[player] = trap[t, 1]; }
            }
            string message = "Player " + (player + 1).ToString() + " is on square " + (playerSquare[player]).ToString();
            if (die1 != die2) { if (player == 0) { player = 1; } else { player = 0; }; }
            return message;
        
        }
        
        public string ToWeirdCase(string s)
        {
            return string.Join(" ", 
              s.Split(' ')
              .Select(w => string.Concat(
              w.Select((ch, i) => i % 2 == 0 ? char.ToUpper(ch) : char.ToLower(ch)
             ))));
        }
     }
}
