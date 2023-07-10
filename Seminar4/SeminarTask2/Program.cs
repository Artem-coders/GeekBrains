// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

void kol (int a)
{
int count = 0;
while (a > 0)
{
    a = a / 10;
    count++;
}
Console.WriteLine($"Колличество чисел: {count}");
}





Console.Write("Введите ваше число: ");
int a = int.Parse(Console.ReadLine());

kol(a);