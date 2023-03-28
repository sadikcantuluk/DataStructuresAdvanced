int Faktoriyel(int sayi)
{
    if (sayi == 0)
        return 1;
    return sayi * Faktoriyel(sayi-1);
}

Console.Write("Bir sayı girin : ");
int sayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"SONUÇ : {Faktoriyel(sayi)}");



Console.ReadKey();

static void BasitFact()
{
    Console.Write("Bir sayı girin : ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Faktoriyel(sayi);

    void Faktoriyel(int sayi)
    {
        int x = 1;
        while (sayi > 1)
        {
            x = x * sayi;
            sayi--;
        }

        Console.WriteLine($"Girdiğiniz sayının faktöriyeli : {x}");
    }
}