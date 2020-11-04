using System;
using System.Linq;

namespace TestDomePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2)));

            //2
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Console.WriteLine(BinarySearchTree.Contains(n2, 3));

            //3
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());

            //4
            Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
        }
    }
    //1
    public class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            var result = names1.Concat(names2);
            return result.Distinct().ToArray();
        }
    }
    //2
    public class Node
    {
        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(int value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

    public class BinarySearchTree
    {
        public static bool Contains(Node root, int value)
        {
            if (root != null)
            {
                if (root.Value == value)
                {
                    return true;
                }
                else if (root.Value > value)
                {
                    return Contains(root.Left, value);
                }
                else if (root.Value < value)
                {
                    return Contains(root.Right, value);
                }
            }
            return false;
        }
    }
    //3
    public class TextInput
    {
        public string Value { get; set; }

        public virtual void Add(char c)
        {
            Value += c;
        }

        public string GetValue()
        {
            return Value;
        }
    }

    public class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            if (Char.IsNumber(c))
            {
                Value += c;
            }

        }

    }

    //4
    public class SortedSearch
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            //return sortedArray.Where(num => num < lessThan).Count();
            //int returnedValued = 0;
            //foreach (int i in sortedArray)
            //{
            //   if (i < lessThan)
            //       returnedValued += 1;
            //      else break;
            //}

            //return returnedValued;

            var valueNum = Array.BinarySearch(sortedArray, lessThan); //better for performance
            return valueNum < 0 ? ~valueNum : valueNum;
        }
    }
}
