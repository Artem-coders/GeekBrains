﻿// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] TranspondSquareArray(int[,] matrix)
{
    if(matrix.GetLength(1) != matrix.GetLength(0))
    {
         Console.WriteLine("нет");
    }

    int tmpElement = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            tmpElement = matrix[i, j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = tmpElement;
        }
        
    }
    return matrix;
}
/////////////////////
int[,] testArray = FillIntMatrix(2, 2);
Print2dIntMatrix(testArray);
Console.WriteLine();
int[,] newArray = TranspondSquareArray(testArray);
Print2dIntMatrix(newArray);
