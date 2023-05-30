using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class MaxHeap<T> : BHeap<T>, IEnumerable<T> where T : IComparable
    {
        public MaxHeap() : base()
        {

        }
        public MaxHeap(int size) : base(size)
        {

        }
        public MaxHeap(IEnumerable<T> collection) : base(collection)
        {

        }
        protected override void HeapfyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var smallerindex = GetLeftChildIndex(index);
                if (HasRightChild(index) && GetRightChild(index).CompareTo(GetLeftChild(index)) > 0)
                {
                    smallerindex = GetLeftChildIndex(index);
                }
                if (Array[smallerindex].CompareTo(Array[index]) < 0)
                {
                    break;
                }

                Swap(smallerindex, index);
                index = smallerindex;
            }
        }

        protected override void HeapfyUp()
        {
            int index = position - 1;
            while (!IsRoot(index) && Array[index].CompareTo(GetParent(index)) > 0)
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }
    }
}
