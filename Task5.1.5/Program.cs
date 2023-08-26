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

                for (int i = 0;i < colors.Length; i++)
                {
                Console.WriteLine($"Input color #{i+1}");
                
                    
                    colors[i] = ShowColor();

                }

                foreach (string color in colors)
                {
                    Console.WriteLine(color);
                }
                

            }

            static string ShowColor()
            {
                
                var color = Console.ReadLine();

                return color;
            }


    }
    }