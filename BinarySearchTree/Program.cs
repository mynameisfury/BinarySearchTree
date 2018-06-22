using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Tree tree = new Tree();
            tree.Add(3);
            tree.Add(2);
            tree.Add(4);
            tree.Add(20);
            tree.Add(1);
            string result = tree.Search(20);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
