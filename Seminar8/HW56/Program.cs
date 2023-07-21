// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.





int[,] table = new int[3, 4];
FillArrayRandom(table);
PrintArray(table);
SortToLower(table);
Console.WriteLine($"Номер столбца с наименьшей суммой: {SortToLower(table)}");


void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


int SortToLower(int[,] array)
{
    int resultColumn = 0;
    int min = int.MaxValue;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int tempSum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            tempSum = tempSum + array[j, i];
        }
        if (tempSum < min)
        {
            min = tempSum;
            resultColumn = i;
        }
    }
    return resultColumn;
}

// Функция вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
