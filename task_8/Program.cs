﻿// // // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

for (int number = 1; number <= N; number++)
    if (number % 2 == 0)
        Console.WriteLine(number);