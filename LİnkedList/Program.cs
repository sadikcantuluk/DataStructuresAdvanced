using LİnkedList;

var linkedList = new SinglyLinkedList<int>();

linkedList.AddFirst(1);
linkedList.AddFirst(2);
linkedList.AddFirst(3);

// 3 2 1 o(1)

linkedList.AddLast(4);
linkedList.AddLast(5);

// 3 2 1 4 5

linkedList.AddAfter(linkedList.Head.Next,32);

// 3 2 32 1 4 5

Console.ReadKey();