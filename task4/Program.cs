﻿// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

// Пример:

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Решение:

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine()!);

int max = a;

if (max < b)
{
   max = b;
} 

if (max < c)
{
   max = c;
} 

Console.Write("Максимальное число: " + max);

