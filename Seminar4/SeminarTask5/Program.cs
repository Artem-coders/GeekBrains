// Выполнить бинарный поиск в массиве

int [] Array = new int [8];

int [] Random(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(0,2);
    Console.Write(Array[i]);
    }
    return array;
    
}

int[] Array2 = Random(Array);
