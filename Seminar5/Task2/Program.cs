// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] Printarray (int[] mas)
{
    Console.Write ("Исходный массив: ");
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-9, 10);
        Console.Write(" " + mas[i]);
    }
    return mas;
}

void ChangeNum (int[] mas)
{
    Console.Write(" Новый массив: ");
    for(int i = 0; i < mas.Length; i++)
    {
        mas[i] *= -1;
        Console.Write(" " + mas[i]);
    }   
}

int[] mas = new int[9];
Printarray (mas);
ChangeNum (mas);