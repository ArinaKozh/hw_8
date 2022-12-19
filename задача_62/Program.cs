/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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
int[,] InitMatrix(int N)
{
    int[,] matrix = new int[N, N];
    Random rnd = new Random();
    for(int i = 0; i<matrix.GetLength(0); i++)
    {   for(int j = 0; j<matrix.GetLength(1); j++)
       {
         matrix[i,j] = rnd.Next(100);
       }
    }
    return matrix;
}
int[,] Spiral(int[,] matrix)
{
    int count = 1;
    int i = 0;
    int j = 0;
    matrix[0,0] = 1;

while (count<=matrix.Length)
{
    if (i <= j + 1 && i + j < matrix.GetLength(0) - 1)
        j += 1;
    else if (i < j && i + j >= matrix.GetLength(0) - 1)
        i += 1;
    else if (i >= j && i + j > matrix.GetLength(0) - 1)
        j -= 1;
    else
        i -=1;
    count +=1;
    matrix[i, j] = count;
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

int[,] matrix = InitMatrix(GetNumber("Введите размер"));
PrintMatrix(Spiral(matrix));
