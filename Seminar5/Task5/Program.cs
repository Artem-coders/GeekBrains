// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int[] Filltarray (int[] mas)
{
    Console.Write ("Исходный массив: ");
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(0, 10);
        Console.Write(" " + mas[i]);
    }
    return mas;
}
int[] GetIncrease(int[] mas)
{
    int[] Inc = null;
    if(mas.Length % 2 == 0)
        Inc = new int[mas.Length/2];
    else
        Inc = new int[mas.Length/2 + 1];

    Console.Write(" Новый массив: ");
    for (int i = 0; i < mas.Length/2; i++)
        {
            Inc[i] = mas[i] * mas[mas.Length - 1 - i];
            Console.Write(" " + Inc[i]);
        }
return Inc;
}
int[] mas = new int[8];
Filltarray(mas);
GetIncrease(mas);