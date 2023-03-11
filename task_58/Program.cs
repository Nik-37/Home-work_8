/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

*//// <summary>
/// данный метод заполняет двумерный массив числами от min до max
/// </summary>
/// <param name="rows">Количество строк </param>
/// <param name="cols">Количество столбцов</param>
/// <param name="min">Минимальное число для рандома</param>
/// <param name="max">Максимальное число для рандома</param>
/// <returns>Заполненный двумерный массив целых чисел</returns>
/// /*При оценивании учитывается чистота программного кода (выбор имени и стиля написания). Учитывается наличие Гитхаба. summary ЖЕЛАТЕЛЬНЫ
/// */

int[,] GetMatrix(int rows, int cols, int min, int max)
{
  int[,] matrix = new int[rows, cols];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      matrix[i, j] = new Random().Next(min, max + 1);
    }
  }

  return matrix;
}

/// <summary>
/// Метод печатает матрицу которую передали на вход
/// </summary>
/// <param name="inputMatrix"> Двумерный массив </param>

void PrintMatrix(int[,] inputMatrix)
{
  for (int i = 0; i < inputMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < inputMatrix.GetLength(1); j++)
    {
      Console.Write(inputMatrix[i,j] + "\t");
    }
    Console.WriteLine();
  }
}

//1. Заполним матрицы
int[,] Matrix_A = GetMatrix(3,5,0,5);
int[,] Matrix_B = GetMatrix(5,4,0,5);
int[,] resultMatrix = new int[3,4];

for(int i = 0; i < Matrix_A.GetLength(0); i++)
{
  for(int j = 0; j < Matrix_B.GetLength(1); j++)
  {
    for(int k = 0; k < Matrix_B.GetLength(0); k++)
    {
      resultMatrix[i,j]+= Matrix_A[i,k] * Matrix_B[k,j];
    }
  }
}

//2. Напечатаем матрицы
Console.WriteLine("Печатаем первую матрицу");
PrintMatrix(Matrix_A);
Console.WriteLine("Печатаем вторую матрицу");
PrintMatrix(Matrix_B);
Console.WriteLine("Печатаем произведение");
PrintMatrix(resultMatrix);
