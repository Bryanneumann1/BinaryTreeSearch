using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {


        static void Main(string[] args)
        {

            BinarySearchTree binaryTree = new BinarySearchTree();

            binaryTree.Add(9);
            binaryTree.Add(6);
            binaryTree.Add(2);
            binaryTree.Add(4);
            binaryTree.Add(5);
            binaryTree.Add(3);

            Console.WriteLine("Tree is:");
            binaryTree.Display();
            Console.WriteLine("\nCount = " + binaryTree.Count);
            Console.WriteLine("\nAdd 99");
            binaryTree.Add(99);
            Console.WriteLine("\nCount = " + binaryTree.Count);
            Console.WriteLine("Search for 9 " + binaryTree.Search(9));
            Console.WriteLine("Search for 3 " + binaryTree.Search(3));
            Console.WriteLine("Search for 7 " + binaryTree.Search(7));


            Console.ReadLine();

        }
    }
}
