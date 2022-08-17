// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetMatrix(int column, int row, int min, int max)
{
   double[,] matrix = new double[column, row];
   Random rnd = new Random();
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = Math.Round((rnd.NextDouble() * (min - max) + max), 1); ;
      }
   }
   return matrix;
}


void PrintMatrix(double[,] array)
{

   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (j == 0) Console.Write("[");
         if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}  ");
         else Console.Write($"{array[i, j],3}]");
      }
      Console.WriteLine();
   }
}


double[,] marixResult = GetMatrix(2, 20, -10, 10);
PrintMatrix(marixResult);