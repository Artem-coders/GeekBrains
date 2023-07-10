// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

internal class Program
{
    private static void Main(string[] args)
    {
        Double x, y, result;
        Console.Write("Введите число A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите число B: ");
        int b = int.Parse(Console.ReadLine());

        result = Math.Pow(a, b);
        Console.WriteLine($"Pow({a},{b}) = {result}");
    }
}