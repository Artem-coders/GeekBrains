// Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдает максимальное из этих чисел.

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число C: ");
int c = int.Parse(Console.ReadLine());

if(a > b)
{
    if(a > c)
    { 
        Console.WriteLine($"Максимальное число = {a}");
    }
    else
    {
        Console.WriteLine($"Максимальное число = {c}");
    }
}     
else if(b > c)
{
    Console.WriteLine($"Максимальное число = {b}");
}
else
{
    Console.WriteLine($"Максимальное число = {c}");
}