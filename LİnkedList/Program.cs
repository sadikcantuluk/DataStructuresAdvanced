using LİnkedList;

var newNode = new SinglyLinkedList<int>();

newNode.AddFirst(1);
newNode.AddFirst(2);
newNode.AddFirst(3);

// 3 2 1 o(1)

newNode.AddLast(4);
newNode.AddLast(5);

// 3 2 1 4 5

Console.ReadKey();