// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Принять число
// Принять второе число
// Сравнить числа
// Вывести максимальное

Console.WriteLine ("Введите первое число");
string input = Console.ReadLine();
int number_1 = Convert.ToInt32(input);
Console.WriteLine ("Введите второе число");
input = Console.ReadLine();
int number_2 = Convert.ToInt32(input);
if (number_1 > number_2) Console.WriteLine (number_1);
else Console.WriteLine(number_2);
