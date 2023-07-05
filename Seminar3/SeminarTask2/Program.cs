﻿// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int GetAreaNumber(int x, int y)
{
    int numberArea = 0;
    if (x > 0 && y > 0)
    {
        numberArea = 1;
    }

    if (x < 0 && y > 0)
    {
        numberArea = 2;
    } 
    if (x < 0 && y < 0)
    {
        numberArea = 3;
    }
     if (x > 0 && y < 0)
    {
        numberArea = 4;
    }
    return numberArea;
}

// ------------------------------------------

Console.Write("Введите координаты Х: "); 
int x = int.Parse(Console.ReadLine());

Console.Write("Введите координаты Y: ");    
int y = int.Parse(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("Координаты должны быть не равны 0");
}
else
{
    int result = GetAreaNumber(x, y);
    Console.WriteLine($"Номер четверти вашей точки: " + result);
}
