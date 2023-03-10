// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = GetMatrix(rows, cols);
PrintMatrix(resultMatrix);
averNumbers(rows, cols);

int[,] GetMatrix(int rows, int cols)
{
  int[,] matrix = new int[rows, cols];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
  }
  return matrix;
}
void PrintMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write(matr[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

void averNumbers(int rows, int cols)
{
  Console.WriteLine("Среднеарефмитическое элементов каждого столбца:");
 
  for (int j = 0; j < cols; j++)
  {
    double sum =0;
    for (int i = 0; i < rows; i++)
    {
      sum += resultMatrix[i, j];
    }
    Console.Write($"{sum / rows:f2} \t");
  }
}
