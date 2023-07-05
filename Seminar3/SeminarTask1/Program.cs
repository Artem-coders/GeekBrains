// [Возвразаемый тип] [Имя метод - глагол]([Параметры метода])
//{
    // код метод
//}

int GetSum(int a, int b)
{
    int sum = a + b;
    return sum;
}


void PrintMessageConsole(string message)
{
    Console.WriteLine(message);
}

// --------------------------------------------------

int mySum = GetSum(10, 15);
PrintMessageConsole(mySum.ToString());