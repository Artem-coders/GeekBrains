// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int Getsum(int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
    {
        sum = sum + i;
    }
    return sum;
}
//----------------------------------------------------

int sum = Getsum(4);
Console.WriteLine(sum);


