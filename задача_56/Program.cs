/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int FindLine(int[,] matrix)
{    
     int[] array = new int[matrix.GetLength(0)];
     for(int i = 0; i<matrix.GetLength(0); i++)
    {   array[i] = 0;
        for(int j = 0; j<matrix.GetLength(1); j++)
       {
         array[i]+=matrix[i,j];
       }
    }
    int Max = array[0];
    int IndexMax = 0;
    for(int k = 0; k<array.Length;k++)
    {
        if (array[k]>Max)
        {
            Max = array[k];
            IndexMax = k;
        }
    }
    return IndexMax;
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

int[,] matrix = InitMatrix(GetNumber("Колво строк"), GetNumber("Колво столбцов"));
PrintMatrix(matrix);
Console.WriteLine(FindLine(matrix)+1);