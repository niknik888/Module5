// Необходимо написать рекурсивный метод, который возводит введенное число N типа int в указанную степень pow типа byte.

using System;
namespace Task558
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = PowerUp(2, 5);
            Console.WriteLine(res);
        }


        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else if (pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, --pow);
            }
        }
    }
}

