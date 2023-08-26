//Разделить метод из задания 5.1.6 GetArrayFromConsole() на два:
//один метод GetArrayFromConsole() должен читать введенные с клавиатуры массивы и возвращать их,
//второй метод SortArray() должен принимать параметром массив array типа данных int, сортировать его и возвращать.



using System;

namespace Task528
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = GetArrayFromConsole();
            SortArray(array);
        }


        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("Введите элемент массива номер {0}: ", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            

            Console.Write("Not sorted result: ");
            foreach (var n in result) { Console.Write ($"{n} "); }

            Console.WriteLine();

            return result;
        }

        static int[] SortArray(int[] result)
        {
            for (int i = 0; i < result.Length; i++)

                for (int j = 0; j < result.Length; j++)

                    if (result[i] < result[j])
                    {
                        var temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }

            Console.Write("Sorted result: ");
            foreach (var n in result) { Console.Write($"{n} "); }
            return result;
        }
    }
}