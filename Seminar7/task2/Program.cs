// // Задайте двумерный масиив размером m * n , заполненый случайными целыми числами и сложить 

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

// Вывод суммы элементов каждой строки
for ( int i = 0; i < countRow; i++)
{
    int sum = 0;
    for ( int j = 0; j < countColumn; j++ )
    {
        sum = sum + array[i, j];
    }
    Console.WriteLine($"В строке под номером [{i}] сумма элентов равна : {sum}");
}
