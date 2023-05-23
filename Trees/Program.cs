using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.BinarySearchTree;

namespace Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var BST = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });


            Console.ReadKey();  
        }
    }
}
