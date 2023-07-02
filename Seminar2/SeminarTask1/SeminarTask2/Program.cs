// Задача 11
// Напишите программу, которая выводит случайное трёзначное число и удаляет вторую цифру этого числа

int randomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {randomNumber}");

int firstDigit = randomNumber / 100;
int secondDigit = randomNumber % 10;
int treeDigit = firstDigit * 10 + secondDigit;

Console.WriteLine("Результат: " + treeDigit);
