// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Enter 1st dimension  :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2nd dimension :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 3rd dimensiom :");
int o = Convert.ToInt32(Console.ReadLine());


int[,,] matrix = new int[m,n,o];

for (int i = 0; i < m; i++)
   for (int j = 0; j < n; j++)
      for (int k = 0; k < o; k++)
       {
            matrix[i,j,k] = new Random().Next(10,100); 
            
        }
Console.WriteLine("Our matrix :");
 
for (int i = 0; i < n; i++)
    {
    for (int j = 0; j < m; j++)
            {
                for (int k = 0; k < o; k++)
                {
                    Console.Write(matrix[i,j,k]+$"({i},{j},{k})  ");
                        
                }
                Console.WriteLine();
                    
            }
    }        
    // Есть возможность сделать через счетчик, чтобы числа не 
    // повторялись, но так массив получится упорядоченным.
    // Еще была идея рандомного заполнения из одномерного массива
    // с последующим удалением, но не сообразил, как. 