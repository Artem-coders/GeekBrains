// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void GetSqrt(int N)
{
    for (int i = 1; i <= N; i++)
    Console.WriteLine($"{i * i * i}");
}
int N = Promt("Введите число: ");
GetSqrt(N);
