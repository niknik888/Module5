//Создайте метод ChangeAge, в который передадите свой возраст. Измените его и выведите на экран исходное значение вне метода.
using System;
using System.Globalization;

namespace Task53
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            int age = 25;
            ChangeAge(ref age);
            Console.WriteLine(age);
        }

        static void ChangeAge(ref int age)
        {
            Console.Write("Input new age - ");
            age = int.Parse(Console.ReadLine());

        }

        */

        // Task 5.3.8
        // Необходимо передать по ссылке размерность массива в метод GetArrayFromConsole и изменить её на 6.
        /*
        static void Main(string[] args)
        {
            int lenghtArray = 4;
            var array = GetArrayFromConsole(ref lenghtArray);

            Console.WriteLine($"{lenghtArray} !!!");
           
        }


        static int[] GetArrayFromConsole(ref int num)
        {
            num = 6;
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
        */

        // Task 5.3.13
        //Используйте код метода SortArray. Сейчас этот метод сортирует массив по возрастанию значения. Создайте методы SortArrayDesc и SortArrayAsc —
        //сортировка массива от большего к меньшему и сортировка массива от меньшего к большему.

        //Метод SortArray модифицируйте так, чтобы он вызвал оба этих метода.Результаты методов SortArrayAsc и SortArrayDesc должны представлять собой массивы.

        //Метод SortArray должен иметь один входной параметр array и два выходных: sorteddesc и sorted asc.


        static void Main(string[] args)
        {
            //var array = GetArrayFromConsole(3);
            
            var array = new[] { 2, 1, 3 };
            SortArray(array, out var sorteddesc, out var sortedasc);
            

            //ShowArray(array, true);
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

        static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            sorteddesc = SortArrayDesc(array);
            sortedasc = SortArrayAsc(array);

            Console.ReadKey();

            

        }


        static int[] SortArrayDesc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)

                for (int j = 0; j < array.Length; j++)

                    if (array[i] > array[j])
                    {
                        var temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }

            Console.WriteLine();
            Console.Write("Desc- ");
            foreach (var n in array) { Console.Write($"{n} "); }

            return array;
        }

        static int[] SortArrayAsc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)

                for (int j = 0; j < array.Length; j++)

                    if (array[i] < array[j])
                    {
                        var temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
            Console.WriteLine();
            Console.Write("Asc- ");
            foreach (var n in array) { Console.Write($"{n} "); }

            return array;
        }

        static int[] ShowArray(int[] array, bool sort = false)
        {   
            
            if (sort == true)
            {
                SortArray(array, out var sorteddesc, out var sorteasc);
            }
            

            Console.Write("Array result: ");
            foreach (var n in array) { Console.Write($"{n} "); }

            return array;
        }
    }

}
