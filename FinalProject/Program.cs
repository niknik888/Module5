using Microsoft.VisualBasic;
using System;
using System.Drawing;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start program");
            Console.WriteLine();

            var information = InputInformation();

            ShowInformation(information);
        }
        //Необходимо создать метод, который заполняет данные с клавиатуры по пользователю (возвращает кортеж):
        // - Имя;
        // - Фамилия;
        // - Возраст;
        // - Наличие питомца;
        //   Если питомец есть, то запросить количество питомцев;
        //   !! Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек(заполнение с клавиатуры);
        // - Запросить количество любимых цветов;
        //   Вызвать метод, который возвращает массив любимых цветов по их количеству(заполнение с клавиатуры);
        //   Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе;
        //   Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
        //   Корректный ввод: ввод числа типа int больше 0.

        static (string name, string lastname, int age, string[] pets, string[] colors) InputInformation()
        {
            (string name, string lastname, int age, string[] pets, string[] colors) User = (null, null, 0, null, null);



            Console.Write("Input your name: ");
            User.name = Console.ReadLine();

            Console.Write("Input your lastname:  ");
            User.lastname = Console.ReadLine();

            Console.Write("Input your age: ");
            User.age = int.Parse(Console.ReadLine());

            Console.Write("Do you have a pet? (true or false): ");
            bool haveAPet = bool.Parse(Console.ReadLine());
            int numberOfPets = 0;

            if (haveAPet == true)
            {
                Console.Write("Enter the number of pets: ");
                numberOfPets = int.Parse(Console.ReadLine());

                User.pets = petNames(numberOfPets);
            }
            

            Console.Write("Enter the number of favorite colors: ");
            int numberOfColors = int.Parse(Console.ReadLine());
            User.colors = favColors(numberOfColors);

            controlNumbers(ref User.age, ref numberOfPets, ref numberOfColors, haveAPet);

            Console.WriteLine();
            return User;
        }

        static string[] petNames(int number)
        {
            string[] petNames = new string[number];

            for (int i = 0; i < number; i++)
            {
                Console.Write($"Input name of pet #{i + 1}: ");
                petNames[i] = Console.ReadLine();

            }
            Console.WriteLine();
            return petNames;
        }

        static string[] favColors(int number)
        {
            string[] favColors = new string[number];

            for (int i = 0; i < number; i++)
            {
                Console.Write($"Input color #{i + 1}: ");
                favColors[i] = Console.ReadLine();

            }
            Console.WriteLine();
            return favColors;
        }

        static void controlNumbers(ref int age, ref int numPet, ref int numColor, bool haveAPet)
        {
            bool ageOk;
            bool numPetOk;
            bool numColorOk;
            

            Console.WriteLine();
            Console.WriteLine("Start control values...");
            if (age == 0)
            {
                ageOk = false;
                Console.Write("Incorrect value of Age. Input new Age: ");
                age = int.Parse(Console.ReadLine());
            }
            else 
            {
                ageOk = true;
                Console.WriteLine("Age is correct!"); 
            }

            if (haveAPet == true && numPet == 0)
            {
                numPetOk= false;
                Console.Write("Incorrect value of Pets. Input new number of Pets: ");
                numPet = int.Parse(Console.ReadLine());
                petNames(numPet);
            }
            else 
            {
                numPetOk = true;
                Console.WriteLine("Number of Pets is correct!"); 
            }

            if (numColor == 0)
            {
                numColorOk = false;
                Console.Write("Incorrect value of Colors. Input new number of Colors: ");
                numColor = int.Parse(Console.ReadLine());
                favColors(numColor);
            }
            else 
            {
                numColorOk = true;
                Console.WriteLine("Colors is correct!"); 
            }

            if (ageOk == true && numPetOk == true && numColorOk == true)
            {
                Console.WriteLine("All values is correct!");
            }
            else
            {
                Console.WriteLine("Not all values is correct!");
                controlNumbers(ref age, ref numPet, ref numColor, haveAPet);
            }

        }

        //Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
        static void ShowInformation((string name, string lastname, int age, string[] pets, string[] colors) info)
        {   
            Console.WriteLine();
            Console.WriteLine("Print all information...");
            Console.WriteLine($"Name: {info.name}");
            Console.WriteLine($"Lastname: {info.lastname}");
            Console.WriteLine($"Age: {info.age}");
            if (info.pets != null)
            {
                Console.WriteLine();
                Console.WriteLine("Pets:");
                foreach (string pet in info.pets)
                {
                    Console.WriteLine(pet);
                }
            }
            else
            {
                Console.WriteLine("You dont have a pets");
            }

            Console.WriteLine();
            Console.WriteLine("Favorite colors:");
            foreach (string color in info.colors)
            {
                Console.WriteLine(color);
            }
        }
    }

}

