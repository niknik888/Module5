using System;

// Напишите программу, которая в цикле вызывает метод ShowColor(), записывает его значение в массив из трех цветов favcolors,
// а потом отображает значения этого массива. 
namespace Task515
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[3];

            var (name, age) = ("Nikita", 25);


            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);
            


            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = ShowColor(name, age);

            }

            Console.WriteLine("Our favorite colors: ");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }


        }

        static string ShowColor(string username, int userage)
        {

            Console.Write($"{username}, {userage} years ago \ninput color - ");
            var color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            return color;
        }


    }
}