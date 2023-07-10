// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


//-----------------------

internal class Program
{
    private static void Main(string[] args)
    {
        int num, r, sum = 0, t;
        Console.Write("Введите пятизначное число: ");
        num = int.Parse(Console.ReadLine());
        if (num > 9999 && num < 100000)
        {
            for (t = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum * 10 + r;
            }
            if (t == sum)
            {
                Console.Write("Палиндромом");
            }
            else
            {
                Console.Write("Не палиндромом");
            }
        }
    }
}