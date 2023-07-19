// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

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
        array[i, j] = new Random().Next( 1, 9 );
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

Console.Write("число: " );
int c = int.Parse( Console.ReadLine());

if (c > countRow && c > countColumn)
 Console.WriteLine("такого числа нет");
 else
 
 Console.WriteLine("Такое число есть");


