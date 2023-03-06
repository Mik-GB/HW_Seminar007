// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1(строчка) 7 (столбец) -> такого числа в массиве нет

Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
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
int[,] resultMatrix = GetMatrix(rows, cols);
PrintMatrix(resultMatrix);


Console.WriteLine("Введите позицию элемента по строке");
int positionX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента по столбцу");
int positionY = Convert.ToInt32(Console.ReadLine());
if (rows < positionX || cols < positionY)
{
  Console.WriteLine($"Элемент отсутствует");
}
else
{
  Console.WriteLine($"Значение элемента находящегося на {positionX} строке и {positionY} столбце равно {resultMatrix[positionX, positionY]}");
}
