﻿// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите кол-во строк: " );
int countRow = int.Parse( Console.ReadLine() );

Console.Write("Введите кол-во столбцов: " );
int countColumn = int.Parse( Console.ReadLine() );

int[,] array = new int[countRow, countColumn];


// Заполнение массива случайными числами (построчно)
for ( int i = 0; i < countRow; i++) // двигается по строками
{
    for ( int j = 0; j < countColumn; j++ ) // двигается по столбцам
    {
        array[i, j] = new Random().Next( 1, 11 );
    }
}
// Вывод массива в консоль
for ( int i = 0; i < countRow; i++)
{
    for ( int j = 0; j < countColumn; j++ )
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(""); // Разделяем

// Вывод средне арифметического
for ( int i = 0; i < countRow; i++)
{
    double sum = 0;
    for ( int j = 0; j < countColumn; j++ )
    {
        sum += array[j, i];     
    }
    Console.WriteLine($"Cреднее арифметическое : {sum / countRow}");
}