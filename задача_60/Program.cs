/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

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
int[,,] InitMatrix(int M, int N, int K)
{
    int[,,] matrix = new int[M, N,K];
    Random rnd = new Random();
    for(int i = 0; i<matrix.GetLength(0); i++)
    {   for(int j = 0; j<matrix.GetLength(1); j++)
       {
         for(int k = 0; k<matrix.GetLength(2); k++)
         {
             matrix[i,j,k] = rnd.Next(100);
         }
       }
    }
    return matrix;
}
void PrintMatrix(int[,,] matrix)
{
        for(int i = 0; i<matrix.GetLength(0); i++)
    {   for(int j = 0; j<matrix.GetLength(1); j++)
       {
         for(int k = 0; k<matrix.GetLength(2); k++)
         {
             Console.Write($"{matrix[i,j,k]}({i},{j},{k})  ");
         }
         Console.WriteLine();
       }
    }
}

PrintMatrix(InitMatrix(GetNumber("M"),GetNumber("N"),GetNumber("K")));