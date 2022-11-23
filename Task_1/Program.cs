//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Enter number of rows :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns :");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Our matrix :");

int [,] matrix = new int [m, n];

for(int i = 0; i < m  ; i++)
{
    for(int j = 0; j < n  ; j++)
    {
        matrix[i,j] = new Random().Next(0,10);

        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Modified matrix :");
for(int i = 0; i < m  ; i++)
{
    for(int j = 0; j < n  ; j++)

    {
        for (int k = j + 1; k < n; k++)
        {

            if (matrix[i,k] > matrix[i,j])
                {
                    int tmp = matrix[i,j];
                    matrix[i,j] = matrix[i,k];
                    matrix[i,k] = tmp;
                }
                
        }        
        Console.Write(matrix[i,j]+"\t");    
    }
    Console.WriteLine();
}