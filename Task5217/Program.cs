//Создайте метод ShowArray с параметрами: массив чисел, признак сортировки логического типа, необязательный параметр, по умолчанию ЛОЖЬ.
//Метод должен выводить массив на экран. Если значение признака сортировки равно ИСТИНА, то предварительно массив нужно отсортировать.

using System;

namespace Task528
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = GetArrayFromConsole(10);
            ShowArray(array, true);
        }


        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("Введите элемент массива номер {0}: ", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }



            Console.Write("Not sorted result: ");
            foreach (var n in result) { Console.Write($"{n} "); }

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


            return result;
        }

        static int[] ShowArray(int[] array, bool sort = false)
        {
            if (sort == true)
            { 
                SortArray(array);
            }

            Console.Write("Array result: ");
            foreach (var n in array) { Console.Write($"{n} "); }

            return array;
        }
    }
}