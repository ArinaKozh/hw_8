/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int GetNumber(string message)
{
   int result = 0;
   bool isCorrect = false;

   while(!isCorrect)
   {

    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out result) )
    {
        isCorrect = true;
    } 
    else
    {
        Console.WriteLine("Некорректно ввели число");
    }
   } 
   return result;
}
int[,] InitMatrix(int M, int N)
{
    int[,] matrix = new int[M, N];
    Random rnd = new Random();
    for(int i = 0; i<matrix.GetLength(0); i++)
    {   for(int j = 0; j<matrix.GetLength(1); j++)
       {
         matrix[i,j] = rnd.Next(100);
       }
    }
    return matrix;
}

int[,] SortArray(int[,] matrix)
{
    int [,] result = new int[matrix.GetLength(0),matrix.GetLength(1)];
    for(int i = 0; i<matrix.GetLength(0); i++)
    {   for(int k = 1; k<matrix.GetLength(1); k++)
       {
          for( int j = 1; j<matrix.GetLength(1); j++)
        
           { if (matrix[i,j]>matrix[i,j-1])
            {
                int temp = matrix[i,j-1];
                matrix[i,j-1] = matrix[i,j];
                matrix[i,j] = temp;
            }
           } 
       
    }
}
return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i,j]} ");
}
Console.WriteLine();
}
}
int[,] matrix = InitMatrix(GetNumber("Колво строк"),GetNumber("Колво столбцов"));
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(SortArray(matrix));