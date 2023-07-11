// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int[] Filltarray (int[] mas)
{
    Console.Write ("Исходный массив: ");
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(0, 150);
        Console.Write(" " + mas[i]);
    }
    return mas;
}
void FindCount (int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if(mas[i] > 9 && mas[i] < 100)
            count++;

    }
    Console.Write("количество элементов массива, значения которых лежат в отрезке [10,99] = " + count);
}
int[] mas = new int[123];
Filltarray (mas);
FindCount(mas);