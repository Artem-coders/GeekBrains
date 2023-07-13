// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void Filltarray (int[] mas)
{
    Console.Write ("Исходный массив: ");
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(100, 1000);
        Console.Write($"{mas[i]} ");
    }
}

int kol (int[] mas)
{
int kol = 0;
for (int i = 0; i < mas.Length; i++)
{
    if(mas[i] % 2 == 0)
    kol++;
    
}
    return kol;
}

int[] mas = new int[4];
Filltarray (mas);
Console.Write ($"Колличество чётных чисел в массиве: {kol(mas)}");