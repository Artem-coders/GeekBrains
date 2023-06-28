//Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдает, какое число большее, а какое меньшее.
//a = 5; b = 7 ->  max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

if(a > b)
{
 Console.WriteLine($"{a} больше, чем {b}");
} else if (a < b)
    {
 Console.WriteLine($"{b} больше, чем {a}");
}
else
{
 Console.WriteLine("Числа равны");
}