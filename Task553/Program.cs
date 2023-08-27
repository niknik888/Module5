using System;

class MainClass
{
    // Сценарий Эхо
    /*
    static void Main(string[] args)
    {
        Console.WriteLine("Напишите что-то");
        var str = Console.ReadLine();

        Console.WriteLine("Укажите глубину эха");
        var deep = int.Parse(Console.ReadLine());

        Echo(str, deep);

        Console.ReadKey();
    }

    static void Echo(string phrase, int deep)
    {
        Console.BackgroundColor = (ConsoleColor)deep;
        var modif = phrase;
        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);
            Console.WriteLine($"...{modif}");
        }
        

        if (deep > 1)
        {
            Echo(modif, deep - 1);
        }
    }
    */

    // Сценарий Факториал
    static void Main(string[] args)
    {
        decimal res = Factorial(20);
        Console.WriteLine(res);
    }
        
        static decimal Factorial(int x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }
}