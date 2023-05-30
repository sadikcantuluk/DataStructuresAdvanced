using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var heap = new MinHeap<int>(new int[] { 4, 1, 10, 8, 7, 5, 9, 3, 2 });

            //Console.WriteLine($"{heap.DeleteMinMax()} silindi.");

            //foreach (var item in heap)
            //{
            //    Console.WriteLine(item);
            //}

            var heap = new MaxHeap<int>() { 54, 45, 36, 27, 29, 18, 21, 99 };

            Console.WriteLine($"{heap.DeleteMinMax()} silindi.");

            foreach (var item in heap)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
