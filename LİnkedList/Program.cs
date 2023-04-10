using LİnkedList;
using LİnkedList.DoublyLinkedList;
using LİnkedList.SinglyLinkedList;
using System.Collections;

var list = new DoublyLinkedList<int>();

list.AddFirst(0);
list.AddFirst(5);
list.AddFirst(7);
list.AddFirst(3);

//3 7 5 0 

list.AddAfter(list.Head.Next, 23);

//3 7 23 5 0

list.AddBefore(list.Head,11);

//11 3 7 23 5 0

list.RemoveFirst();

//3 7 23 5 0

list.RemoveLast();

//3 7 23 5 






foreach (var item in list)
{
    Console.WriteLine(item);
}


Console.ReadKey();

