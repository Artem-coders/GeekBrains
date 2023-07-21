// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Write("Введите кол-во строк: " );
int countRow = int.Parse( Console.ReadLine() );

Console.Write("Введите кол-во столбцов: " );
int countColumn = int.Parse( Console.ReadLine() );

int[,] A = new int[countRow,countColumn];
for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
           A[i, j] = new Random().Next(1, 10);
           Console.Write(A[i, j] + " ");
        }
        Console.WriteLine();
    }

Console.Write("Введите кол-во строк: " );
int countRow2 = int.Parse( Console.ReadLine() );

Console.Write("Введите кол-во столбцов: " );
int countColumn2 = int.Parse( Console.ReadLine() );

int[,] B = new int[countRow,countColumn];
for (int i = 0; i < B.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            B[i, j] = new Random().Next(1, 10);
            Console.Write(B[i, j] + " ");
        }
        Console.WriteLine();
    }

int[,] Multiplication(int[,] a, int[,] b)
{
int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i,j] += a[i,k] * b[k,j];
                    }
                }
            }
            return r;
}
int[,] C = Multiplication(A, B);
Print(C);
void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }