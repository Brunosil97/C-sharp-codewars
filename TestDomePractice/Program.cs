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

            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Console.WriteLine(BinarySearchTree.Contains(n2, 3));
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
}
