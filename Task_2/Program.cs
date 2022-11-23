//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Enter number of rows :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max number :");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] matrix = new int [m, n];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,k+1);

        Console.Write(matrix[i,j]+"\t");

    }
    Console.WriteLine();

}

int [] sum = new int[matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(0); i++)
    {           
        sum[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j]; 
        }                 
        Console.WriteLine($"{i} sum is : {sum[i]}");
    }

int min = sum[0], row = 0;   
for (int i = 0; i < n; i++)
    {        
        if (sum[i] < min)
            {
                min = sum[i];
                row = i;                
            }   
    }
    Console.WriteLine($"{row} row has minimal sum : {min}");            