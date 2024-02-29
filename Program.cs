using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите год: ");
        int year = int.Parse(Console.ReadLine());

        if (year % 4 == 0)
        {
            Console.WriteLine("Год високосный");
        }
        else
        {
            Console.WriteLine("Год не високосный");
        }
    }
}
