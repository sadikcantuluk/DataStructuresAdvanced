var charList = new char[] { 'a', 'b', 'c', 'd' };

var stack1 = new Stack.Stack<char>();
var stack2 = new Stack.Stack<char>(Stack.StackType.LinkedList);

foreach (var item in charList)
{
    Console.WriteLine(item);
    stack1.Push(item);
    stack2.Push(item);
}

Console.WriteLine("\nPeek");
Console.WriteLine($"Stack 1 : {stack1.Peek()}");
Console.WriteLine($"Stack 2 : {stack2.Peek()}");

Console.WriteLine("\nCount");
Console.WriteLine($"Stack 1 : {stack1.Count}");
Console.WriteLine($"Stack 2 : {stack2.Count}");

Console.WriteLine("\nPop");
Console.WriteLine($"{stack1.Pop()} has been removed.");
Console.WriteLine($"{stack2.Pop()} has been removed.");

Console.ReadKey();

