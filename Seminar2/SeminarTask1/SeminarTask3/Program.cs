// Задача 12
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine("Кратно");
}

else
{
    Console.WriteLine($"Не кратно, остаток {a % b}");
}
