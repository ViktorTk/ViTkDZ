// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
    {
 Console.WriteLine(number + " - Четное число (делится на два без остатка): ");
    }
 else
    {
 Console.WriteLine(number + " - Нечетное число (не делится на два без остатка");
    }