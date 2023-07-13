// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int [] array = new int[12];
Console.Write ("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i] + " ");
}

Console.WriteLine();

// Подчяёт суммы отрицательных элементов

int sumPositive = 0;
int sumNegative = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    sumPositive = sumPositive + array[i];

    if (array[i] < 0)
    sumNegative = sumNegative + array[i];
}


Console.WriteLine($"Сумма отрицательных чисел: {sumNegative}");
