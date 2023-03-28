using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Ve_Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var arry = new Array.Array<int>() { 1, 2, 3, 4 };
            //var crry = (Array.Array<int>)arry.Clone(); //VEYA
            var crry = arry.Clone() as Array.Array<int>;

            crry.Add(99);

            foreach (var item in arry)
            {
                Console.Write($"{item,-3}");
            }

            Console.WriteLine();

            foreach (var item in crry)
            {
                Console.Write($"{item,-3}");
            }



            Console.ReadKey();
        }

        private static void NewMethod()
        {
            var arry2 = new Array.Array<int>() { 36, 6 };
            var arry3 = new int[] { 39, 34 };
            var arry4 = new List<int>() { 60, 10 };
            var arry5 = new ArrayList() { 20, 30, 40 };

            var arry = new Array.Array<int>();

            for (int i = 0; i < 10; i++)
            {
                arry.Add(i + 1);
                Console.WriteLine($"{i + 1} has been adde to array.");
                Console.WriteLine($"Count : {arry.Count} / Capacity : {arry.Capacity}");
            }

            Console.WriteLine();

            for (int i = arry.Count; i >= 1; i--)
            {
                Console.WriteLine($"{arry.Remove()} has benn removed from the array.");
                Console.WriteLine($"Count : {arry.Count} / Capacity : {arry.Capacity}");
            }


            //EKLEME

            //arry.Add(36);
            //arry.Add(6);
            //arry.Add(39);
            //arry.Add(34);
            //arry.Add(60);
            //arry.Add(10);
            //arry.Add(20);
            //arry.Add(30);
            //arry.Add(40);


            //arry.Remove();
            //arry.Remove();
            //arry.Remove();
            //arry.Remove();
            //arry.Remove();

            //Console.WriteLine("Elemanlar");

            //foreach (var item in arry)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //Console.WriteLine("2'ye tam bölünen elemanlar");

            //arry.Where(x => x % 2 == 0)
            //    .ToList()
            //    .ForEach(x => Console.WriteLine(x));

            //Console.WriteLine($"Eleman sayısı:{arry.Count} - Kapasite:{arry.Capacity}");
        }
    }
}
