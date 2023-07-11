// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
//6, 1, 33 -> [6, 1, 33]

internal class Program
{
    private static global::System.Int32 Main(string[] args)
    {
        int[] Array = new int[8];

        int[] Random(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(Array[i]);
            }
        }

        int[] Array2 = Random(Array);


        
int Prompt (string message)
System.Console.Write (message);
string ReadInput = System.Console.Readline () :
int result - int. Parse (ReadInput); //приводим к числу
return result; //возвращаем результат
// метод для получения случайных значений массива
int [] GenerateArray (int Length, int minValue, int maxValue)
{
int[] array - new int (Length): // обьявляем массив
Random random = new Random () ;
for (int 1 - 0; 1 < Length; 1++)
array(i) - random. Next (minValue, maxValue + 1): // заполняем
случайными цифрами из диапазона SatrArr до EndArr
]
return array:
void PrintArray (int [] array)
System.Console.Write (" [");
for (int 1 - 0; 1 < array. Length - 1; 1++)
System, Console.Write ($" (array(1]), ") ; / /вывод значения массива
]
массива
System, Console.Write (S" (array [array, Length - 1])"); / /вывод значения
System. Console.WriteLine (" ]");
int length - Prompt ("Длина массива: "):
int min - Prompt ("Начальное значение, для диапазона случайного числа: ") ; int max - Prompt ("Конечное значение, для диапазона случайного числа:") ;
Int [l array - GenerateArray (length, min, max) ; / / заполнение массива
случаными числами
PrintArray (array) ; // вывод массива