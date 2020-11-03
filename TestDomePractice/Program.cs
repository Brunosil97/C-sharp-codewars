using System;
using System.Linq;

namespace TestDomePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2)));
        }
    }

    public class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            var result = names1.Concat(names2);
            return result.Distinct().ToArray();
        }
    }
}
