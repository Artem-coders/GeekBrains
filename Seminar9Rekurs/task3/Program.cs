// Напишите программу, которая на вход принимает два числа A и B , и возвращает число А в целую степень В с помощью рекурсии

int GetSum(int A, int B)
{
    if (B == 1) return A;

    int temp = GetSum(A, B - 1) *A;
    return temp;
}

///
Console.WriteLine(GetSum(3, 5));
