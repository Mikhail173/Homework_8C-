// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int numRow = 4;
int numCol = 4;
int[,] Array = new int[numRow, numCol];
FillArray(Array, numRow, numCol);
Console.WriteLine();
PrintArray(Array);

int[,] FillArray(int[,] array, int numRow, int numCol)
{
    int counter = 1, i = 0, j = 0;
    while (counter <= numRow * numCol)
    {
        array[i, j] = counter;
        counter++;
        if (i <= j + 1 && i + j < numCol - 1)
        {
            j++;
        }
        else if (i < j && i + j >= numRow - 1)
        {
            i++;
        }
        else if (i >= j && i + j > numCol - 1)
        {
            j--;
        }
        else
        {
            i--;
        }

    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10)
            {
                Console.Write($"0{array[i, j]} ");
            }
            else 
            {
                Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}