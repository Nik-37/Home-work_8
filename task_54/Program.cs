/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/// 
/// <summary>
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
void sortRow(int[,]matrix, int rowNumber)
{
  for(int i = 0; i < matrix.GetLength(1) - 1; i++)
  {
    for(int j = i; j < matrix.GetLength(1); j++)
    {
      if(matrix[rowNumber,i] < matrix[rowNumber,j])
      {
        int temp = matrix[rowNumber,i];
        matrix[rowNumber,i] = matrix[rowNumber,j];
        matrix[rowNumber,j] = temp;
      }
    }
  }
}

int[,] resultMatrix = GetMatrix(3,5,0,10);


PrintMatrix(resultMatrix);
Console.WriteLine("Отсортированный массив");
for(int i = 0; i < resultMatrix.GetLength(0); i++)
{
  sortRow(resultMatrix,i);
}
PrintMatrix(resultMatrix);