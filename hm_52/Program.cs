// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("введите количество строк  ");
int len = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите  количество столбцов  ");
int high = Convert.ToInt32(Console.ReadLine());



int[,] GetMatrix(int row, int colum)
{
   int[,] matrix = new int[row, colum];
   Random rnd = new Random();
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = rnd.Next(1, 10);
      }
   }
   return matrix;
}

void PrintMatrix(int[,] array)
{

   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (j == 0) Console.Write("[");
         if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
         else Console.Write($"{array[i, j],3}]");
      }
      Console.WriteLine();
   }
}

void GetNum(int[,] matrix, int row, int colum)
{
   if (row >= colum)
   {
      for (int i = 0; i < colum; i++)
      {
         double sum = 0;
         for (int j = 0; j < row; j++)
         {
            sum += matrix[j, i];
         }
         Console.WriteLine("Среднее арифметическое столбца № {0} => {1}", i + 1, Math.Round((sum / row), 1));
      }
   }
   else
   {
      int cof = colum - row;
      for (int i = 0; i < row + cof; i++)
      {
         double sum = 0;
         for (int j = 0; j < colum - cof; j++)
         {
            sum += matrix[j, i];
         }
         Console.WriteLine("Среднее арифметическое столбца № {0} => {1}", i + 1, Math.Round((sum / row), 1));
      }
   }
}

int[,] marixResult = GetMatrix(len, high);
PrintMatrix(marixResult);
Console.WriteLine();
GetNum(marixResult, len, high);