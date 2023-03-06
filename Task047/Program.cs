// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] GetMatrix(int rows, int cols)
{
  double[,] matrix = new double[rows, cols];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      matrix[i,j] = new Random().NextDouble();
    }
  }
  return matrix;
}

void PrintMatrix (double[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write(Math.Round(matr[i, j], 2) + "\t");
    }
    Console.WriteLine();
  }
}
double [,] resultMatrix = GetMatrix(rows, cols);
PrintMatrix(resultMatrix);