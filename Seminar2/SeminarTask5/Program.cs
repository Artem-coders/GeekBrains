// Задача 16
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

if ((a * a == b) || (b * b == a))
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}