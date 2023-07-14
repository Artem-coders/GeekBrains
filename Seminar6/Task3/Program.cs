// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10

Console.WriteLine("Введите число ");
int dec = int.Parse(Console.ReadLine());
string binary = "";

while(dec != 0)
{
    int mod = dec % 2;
    binary = mod.ToString() + binary;
    dec = dec / 2;
}

Console.WriteLine(binary);