using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LİnkedList.SinglyLinkedList
{
    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode<T> Next { get; set; }
        public T Value { get; set; }

        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }

        public SinglyLinkedListNode()
        {

        }

        public override string? ToString()
        {
            return $"{Value}";
        }

        #region Not
        //T tipinde gelen value değerine node yapısı kazandıran 
        //    bir yapıdır.Node=Value + Next
        #endregion

    }
}
