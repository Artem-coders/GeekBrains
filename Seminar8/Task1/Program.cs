// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Метод который генерирует матрицу
int[,] FillIntMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(-100, 100);
        }
    }
    return matrix;
}

// метод который печатает 
void Print2dIntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(string.Format("{0,8}", matrix[i, j]));
        }
        Console.WriteLine();
    }
}

int[,] ReverseFirstLastRow(int[,] matrix)
{
    int tempElement = 0;
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        tempElement = matrix[0, i];
        matrix[0,i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = tempElement;

    }
    return matrix;
}

int[,] testArray = FillIntMatrix(4, 4);
Print2dIntMatrix(testArray);
Console.WriteLine();
int[,] resultArray = ReverseFirstLastRow(testArray);
Print2dIntMatrix(resultArray);

