// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.Write("1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("2: ");
int b = int.Parse(Console.ReadLine());
Console.Write("3: ");
int c = int.Parse(Console.ReadLine());

if (a < (b + c) && b < (a + c) && c < (b + a))
{
    Console.WriteLine("Треугольник");
}

else Console.WriteLine("Не треугольник");