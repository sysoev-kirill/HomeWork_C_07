// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7->такого числа в массиве нет

Console.Write("Введите номер столбца и строки (через запятую): ");
string[] text = Console.ReadLine().Split(',');
int a = int.Parse(text[0]);
int b = int.Parse(text[1]);
Console.WriteLine("введите количество строк в массиве  ");
int len = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите  количество столбцов массиве  ");
int high = Convert.ToInt32(Console.ReadLine());


int[,] GetMatrix(int row, int colum, int min, int max)
{
   int[,] matrix = new int[row, colum];
   Random rnd = new Random();
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = rnd.Next(min, max);
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

void CheckNum(int[,] matrix, int rowA, int collB)
{
   int sum = 0;
   if (rowA <= matrix.GetLength(0) & collB <= matrix.GetLength(1))
   {
      sum = matrix[rowA - 1, collB - 1];
      Console.WriteLine($"Значение элемента в столбце № {collB}, строке № {rowA} => {sum}");

   }
   else
      Console.WriteLine("Tакого числа нет в массиве");
}


int[,] marixResult = GetMatrix(len, high, 0, 10);
PrintMatrix(marixResult);
Console.WriteLine();
CheckNum(marixResult, a, b);