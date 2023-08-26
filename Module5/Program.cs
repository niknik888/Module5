
using System.Reflection.Metadata;

(string Name, string[] Dishes) User;
User.Dishes = new string[5];

Console.Write("Input Name - ");
User.Name = Console.ReadLine();

for (int i = 0; i < User.Dishes.Length; i++)
{
    Console.Write($"Input dish #{i+1} - ");
    User.Dishes[i] = Console.ReadLine();
}