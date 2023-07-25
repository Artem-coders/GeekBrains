// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
// 453 -> 12
// 45 -> 9

int GetSum(int n)
{
    if (n == 0) return 0;

    int temp = n % 10 + GetSum(n / 10);
    return temp;
}

///
Console.WriteLine(GetSum(453));