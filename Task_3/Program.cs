//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Enter number of rows of the 1st matrix :");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns of the 1st matrix :");
int l = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of rows of the 2nd matrix :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns of the 2nd matrix :");
int n = Convert.ToInt32(Console.ReadLine());

if(l != m)
{
    Console.WriteLine("We cannot multiply these matrixes!");
}

int[,] Matrix1 = new int[k, l];
CreateArray(Matrix1);
Console.WriteLine();
Console.WriteLine("First matrix:");
WriteArray(Matrix1);

int[,] Matrix2 = new int[m, n];
CreateArray(Matrix2);
Console.WriteLine();
Console.WriteLine("Second matrix:");
WriteArray(Matrix2);

int[,] resultMatrix = new int[k,n];

MultiplyMatrix(Matrix1, Matrix2, resultMatrix);
Console.WriteLine();
Console.WriteLine("Multiplied matrix:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] Matrix1, int[,] Matrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Matrix1.GetLength(1); k++)
      {
        sum += Matrix1[i,k] * Matrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}


void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,10);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j]+"\t");
    }
    Console.WriteLine();
  }
}