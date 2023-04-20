var list = new int[] { 1, 2, 3, 4, 5 };

var q1 = new Queue.Queue<int>();
var q2 = new Queue.Queue<int>(Queue.QueueType.LinkedList);

foreach (var item in list)
{
    Console.WriteLine(item);
    q1.EnQueue(item);
    q2.EnQueue(item);
}

Console.WriteLine("\nCount");
Console.WriteLine($"q1 Count: {q1.Count}");
Console.WriteLine($"q2 Count: {q2.Count}");

Console.WriteLine("\nPeek");
Console.WriteLine($"q1 Peek: {q1.Peek()}");
Console.WriteLine($"q2 Peek: {q2.Peek()}");

Console.WriteLine("\nEnQueue");
Console.WriteLine($"{q1.DeQueue()} has been removed.");
Console.WriteLine($"{q2.DeQueue()} has been removed.");

Console.ReadKey();