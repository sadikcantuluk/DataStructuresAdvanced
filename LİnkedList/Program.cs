﻿using LİnkedList;
using System.Collections;

var list = new List<int>();
list.Add(6);
list.Add(7);
var linkedList = new SinglyLinkedList<int>(list);

linkedList.AddFirst(1);
linkedList.AddFirst(2);
linkedList.AddFirst(3);

// 3 2 1 o(1)

linkedList.AddLast(4);
linkedList.AddLast(5);

// 3 2 1 4 5

linkedList.AddAfter(linkedList.Head.Next, 32);

// 3 2 32 1 4 5

linkedList.RemoveFirst();

// 2 32 1 6 7 4 5

linkedList.RemoveLast();

// 2 32 1 6 7 4 

linkedList.Remove(1);

// 2 32 6 7 4 


foreach (var item in linkedList)
{
    Console.WriteLine(item);
}


Console.ReadKey();

static void LINQ()
{
    //Langue Integrated Query --LINQ

    var rnd = new Random();
    var initial = Enumerable.Range(1, 10).OrderBy(i => rnd.Next()).ToList();

    var q = from item in initial
            where item % 2 == 0
            select item;

    foreach (var item in initial)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine();

    foreach (var item in q)
    {
        Console.WriteLine(item);
    }
}