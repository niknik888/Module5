//Используйте методы из задания 5.2.8. Модифицируйте метод GetArrayFromConsole так,
//чтобы размерность массива указывалась в качестве необязательного параметра num. Значение по умолчанию оставить 5. 


using System;

namespace Task528
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = GetArrayFromConsole();
            var sortedarray = SortArray(array);
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

            Console.Write("Sorted result: ");
            foreach (var n in result) { Console.Write($"{n} "); }
            return result;
        }
    }
}