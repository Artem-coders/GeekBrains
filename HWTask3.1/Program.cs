﻿// Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдает максимальное из этих чисел.
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите стретье число: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.WriteLine($"Наибольшее значение: {max}");