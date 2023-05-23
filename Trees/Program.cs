using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Trees.BinarySearchTree;
using Trees.BinaryTree;

namespace Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });

            //InOrder
            new BinaryTree<int>().InOrder(BST.Root).ForEach(x => Console.Write(x + " "));

            Console.WriteLine();

            //PerOrder
            new BinaryTree<int>().PreOrder(BST.Root).ForEach(x => Console.Write(x + " "));

            Console.WriteLine();

            //PostOrder
            new BinaryTree<int>().PostOrder(BST.Root).ForEach(x => Console.Write(x + " "));


            Console.ReadKey();
        }
    }
}
