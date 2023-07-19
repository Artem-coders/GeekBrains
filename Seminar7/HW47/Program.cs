// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

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
        array[i, j] = new Random().Next( -11, 11 );
    }
}
// Вывод массива в консоль
for ( int i = 0; i < countRow; i++)
{
    for ( int j = 0; j < countColumn; j++ )
    {
        Console.Write($"{array[i, j]:F1}" + " ");
    }
    Console.WriteLine();
}
