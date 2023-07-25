// Задача 3
//Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. Определите, является ли ваша строка допустимой.
//Исходная строка считается допустимой при условии:
//1. Открытые скобки должны быть закрыты скобками того же типа.
//2. Открытые скобки должны быть закрыты в правильном порядке.
//4. Каждая закрывающия скобка имеет соответствующую открытыю скобку того же типа.

//Пример 1:
//Входная строка: s = "()"
//Результат: true

//Пример 2:
//Входная строка: s = "()[]{}"
//Результат: true

//Пример 3:
//Входная строка: s = "(]"
//Результат: false

//Пример 4:
//Входная строка: s = "()[]{()}"
//Результат: true

using System;
using System.Collections.Generic;

class Program
{
    static bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
                stack.Push(c);
            else if (c == ')' && (stack.Count == 0 || stack.Pop() != '('))
                return false;
            else if (c == ']' && (stack.Count == 0 || stack.Pop() != '['))
                return false;
            else if (c == '}' && (stack.Count == 0 || stack.Pop() != '{'))
                return false;
        }

        return stack.Count == 0;
    }

    static void Main()
    {
        Console.WriteLine(IsValid("()")); // Выведет true
        Console.WriteLine(IsValid("()[]{}")); // Выведет true
        Console.WriteLine(IsValid("(]")); // Выведет false
        Console.WriteLine(IsValid("()[]{()}")); // Выведет true
    }
}