//Модифицируйте метод из скринкаста:  после ввода массива с клавиатуры необходимо отсортировать массив и вывести его на экран.

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task516
{
    class Program
    {
        static void Main(string[] args)
        {
            GetArrayFromConsole();

        }


        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < result.Length; i++)

                for (int j = 0; j < result.Length; j++)

                    if (result[i] < result[j])
                    {
                        var temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }

            Console.WriteLine("Result");
            foreach (var n in result) { Console.WriteLine(n); }


            return result;
        }
    }
}