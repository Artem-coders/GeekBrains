﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трёх значное число: ");
int a = int.Parse(Console.ReadLine());



if ((a < 1000) && (a >= 100))
{
    int m = (a % 100) / 10;
    Console.Write($"Второе число: {m}");
}
else
{
    Console.Write("Не трёхзначное число");
}