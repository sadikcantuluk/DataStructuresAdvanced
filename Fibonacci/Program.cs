int Fibonacci(int sayi)
{
    if (sayi == 0)
        return 0;
    else if (sayi == 1)
        return 1;
    else if (sayi > 1)
        return Fibonacci(sayi - 1) + Fibonacci(sayi - 2);
    else
        return -1;
}

Console.Write("Fibonacci dizi uzunluğunu gir : ");
int uzunluk = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < uzunluk; i++)
{
    Console.Write("{0} ", Fibonacci(i));
}


Console.ReadKey();
