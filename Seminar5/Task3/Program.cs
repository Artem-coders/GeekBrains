// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] Filltarray (int[] mas)
{
    Console.Write ("Исходный массив: ");
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-9, 10);
        Console.Write(" " + mas[i]);
    }
    return mas;
}

bool IsNumber (int[] mas, int num)
{
    for (int i = 0; i < mas.Length; i++)
    {
        if (num == mas[i])
            return true;
    }
    return false;
}
int[] mas = new int[10];
Filltarray(mas);
int num = Prompt(" Введите число: ");
if (IsNumber(mas, num) == true)
    Console.Write ("Такое число есть в массиве: ");
else 
    Console.Write ("Такого числа нет массиве: ");
