// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] array = new double[4];
Random rand = new Random();

Console.Write ("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 100) + rand.NextDouble();
    Console.Write(Math.Round(array[i], 2) + " ");
}

Console.WriteLine();

double raz(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
        i++;
    }
    {
        return max - min;
    }
}
Console.Write($"Разнийа между максимальным и минимальным числом: {raz(array):F2}");