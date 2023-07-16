// Есть массив цел чисел, могут повторять числа, возьмёт и скажет какие числа повторяются

int[] a = {1, 2, 3, 3, 4, 1, 4, 2, 2, 3};
for(int i = 0; i < a.Length; i++)
{
    int count = 0;
    int temp = a[i];
    for(int j = 0; j < a.Length; j++)
    {
        if(temp == a[j] && temp != 0)
        {
            count++;
            a[j] = 0;
        }
    }
    if (count > 1)
    Console.WriteLine($"Число {temp} встречается {count} раз");
}
