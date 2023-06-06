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

            ////InOrderRecursive
            //new BinaryTree<int>().InOrderRecursion(BST.Root).ForEach(x => Console.Write(x + " "));

            //Console.WriteLine();

            ////InOrderİteratif
            //new BinaryTree<int>().InOrderIteratif(BST.Root).ForEach(x => Console.Write(x + " "));

            ////PerOrderRecursive
            //new BinaryTree<int>().PreOrderRecursion(BST.Root).ForEach(x => Console.Write(x + " "));

            //Console.WriteLine();

            ////PerOrderIteratif
            //new BinaryTree<int>().PreOrderIteratif(BST.Root).ForEach(x => Console.Write(x + " "));

            //Console.WriteLine();

            ////PostOrderRecursive
            //new BinaryTree<int>().PostOrderRecursion(BST.Root).ForEach(x => Console.Write(x + " "));

            //Console.WriteLine();

            ////PostOrderIteratif
            //new BinaryTree<int>().PostOrderIteratif(BST.Root).ForEach(x => Console.Write(x + " "));

            ////Level Order
            //new BinaryTree<int>().LevelOrderTraversal(BST.Root).ForEach(x => Console.Write(x + " "));

            //Console.WriteLine($"Max Value: {BST.FindMax(BST.Root)}"); 
            //Console.WriteLine($"Min Value: {BST.FindMin(BST.Root)}"); 

            //var key = BST.Find(BST.Root,55);
            //Console.WriteLine($"Value:{key.Value} Left:{key.Left.Value} Right:{key.Right.Value}");

            ////REMOVE
            //BST.Remove(BST.Root,20);
            //new BinaryTree<int>().InOrderRecursion(BST.Root).ForEach(x => Console.Write(x + " "));

            //var depth = BinaryTree<int>.MaxDepth(BST.Root);
            //Console.WriteLine(depth);

            //var deepestValue = new BinaryTree<int>().DeepestNode(BST.Root);
            //Console.WriteLine(deepestValue);

            //NUMBER OF LEAFS
            //Console.WriteLine(BinaryTree<int>.NumberOfLeafs(BST.Root));



            Console.ReadKey();
        }
    }
}
