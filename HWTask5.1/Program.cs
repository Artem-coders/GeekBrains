// Напишите программу, которая принимаает на вход число (>0) и вывод все числа от 1 до этого числа
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int index = 1;
while (index <= number)
{
    Console.WriteLine(index);
    index = index +1;
}
