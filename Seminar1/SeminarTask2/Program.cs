// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if ((number >= 1) && (number <= 7)){
    if (number == 1){
        Console.WriteLine("Monday");
    }
    else if (number == 2){
    Console.WriteLine("Thuesday");
    }
    else if (number == 3){
        Console.WriteLine("Wednasday");
    }
    else if (number == 4){
        Console.WriteLine("Thursday");
    }
    else if (number == 5){
        Console.WriteLine("Friday");
    }
    else if (number == 6){
        Console.WriteLine("Saturday");
    }
    else {
        Console.WriteLine("Sunday");
    }
}

else{
    Console.WriteLine("Неправильное число");
}   
    

