/*
 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
         matrix[i,j] = rnd.Next(10);
       }
    }
    return matrix;
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] NewMatrix = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
     for(int i = 0; i<matrix1.GetLength(0); i++)
    {   for(int j = 0; j<matrix1.GetLength(1); j++)
       {
         NewMatrix[i,j] = matrix1[i,j]*matrix2[i,j];
       }
    }
    return NewMatrix;

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

int M = GetNumber("Колво строк");
int N = GetNumber("Колво столбцов");
int[,] matrix1 = InitMatrix(M,N);
int[,] matrix2 = InitMatrix(M,N);

PrintMatrix(matrix1);
Console.WriteLine();

PrintMatrix(matrix2);
Console.WriteLine();

PrintMatrix(MultiplyMatrix(matrix1,matrix2));
