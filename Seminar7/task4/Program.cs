// Задача 49: Задайте двумерный массив. 
//Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Console.Write("Введите кол-во строк: " );
int countRow = int.Parse( Console.ReadLine() );

Console.Write("Введите кол-во столбцов: " );
int countColumn = int.Parse( Console.ReadLine() );

int[,] array = new int[countRow, countColumn];

// генерируем числа
for ( int i = 0; i < countRow; i++) // двигается по строками
{
    for ( int j = 0; j < countColumn; j++) // двигается по столбцам
    {
        array[i, j] = new Random().Next(1, 12);
    }
}
// выводим
for ( int i = 0; i < countRow; i++)
{
    for ( int j = 0; j < countColumn; j++ )
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(""); // Разделяем
// выполняем условие
for ( int i = 0; i < countRow; i++) // двигается по строками
{
    for ( int j = 0; j < countColumn; j++) // двигается по столбцам
    {
        if (i % 2 == 0)
        {
        array[i, j] = array[i, j] * array[i, j]; 
        }
        Console.Write(array[i, j] + " ") ;
        
    }
    Console.WriteLine();
}
