using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Ve_Koleksiyonlar.Array
{
    public class Array<T> : IEnumerable<T>, ICloneable
    {
        private T[] array;

        public int Count { get; private set; }
        public int Capacity => array.Length;

        public Array()
        {
            array = new T[2];
            Count = 0;
        }

        public Array(params T[] initial)
        {
            array = new T[initial.Length];
            Count = 0;
            foreach (var item in initial)
            {
                Add(item);
            }
        }

        public Array(IEnumerable<T> collection)
        {

            array = new T[collection.ToArray().Length];
            Count = 0;
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public void Add(T item)
        {
            if (array.Length == Count) //array.Length : Dizinin boyutunu verir.
            {                          //Yani başlangıçta bu değer 2 dir.
                DoubleArray();
            }

            array[Count] = item;
            Count++;
        }

        public T Remove()
        {
            if (Count == 0)
            {
                throw new Exception("Eleman yok.");
            }

            var temp = array[Count - 1];
            if (Count > 0)
            {
                Count--;
            }

            if (array.Length / 4 == Count)
            {
                HalfArray();
            }

            return temp;
        }

        public void HalfArray()
        {
            if (array.Length > 2)
            {
                var temp = new T[array.Length / 2];
                System.Array.Copy(array, temp, Count);
                array = temp;
            }
        }

        private void DoubleArray()
        {
            var temp = new T[array.Length * 2];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    temp[i] = array[i];
            //}

            System.Array.Copy(array, temp, array.Length);

            array = temp;
        }

        public object Clone()
        {
            //return this.MemberwiseClone(); //Eşelon (sığ) copy.
            var copyarry = new Array<T>();
            foreach (var item in this)
            {
                copyarry.Add(item);
            }

            return copyarry;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return array.Take(Count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
