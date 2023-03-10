/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
построчно выводить массив,добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/// 
/// <summary>
/// данный метод заполняет трехмерный массив двузначными числами от min до max
/// </summary>
/// /// <param name="pages">Количество листов</param>
/// <param name="rows">Количество строк </param>
/// <param name="cols">Количество столбцов</param>
/// <param name="min">Минимальное число для рандома</param>
/// <param name="max">Максимальное число для рандома</param>
/// <returns>Заполненный двумерный массив целых чисел</returns>
/// 
int[,,] GetMatrix(int pages, int rows, int cols, int min, int max)
{
  int[,,] matrix = new int[pages, rows, cols];
  for (int n = 0; n < pages; n++)
  {
    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < cols; j++)
        {
        matrix[n,i, j] = new Random().Next(min, max + 1);
        }
    }
  }
return matrix;
}

/// <summary>
/// Метод печатает матрицу которую передали на вход
/// </summary>
/// <param name="inputMatrix"> Трехмерный массив </param>
void PrintMatrix(int[,,] inputMatrix)
{
for(int n = 0; n < inputMatrix.GetLength(0); n++)
{
  for(int i = 0; i < inputMatrix.GetLength(1); i++)
  {
    for(int j = 0; j < inputMatrix.GetLength(1); j++)
    {
      Console.Write("{0}({1},{2},{3})   ", inputMatrix[n,i,j],n,i,j);
    }
    Console.WriteLine();
  }
}
}
//1. Заполним матрицу
int[,,] resultMatrix = GetMatrix(2,2,2,10,99);

//2. Напечатаем матрицу

PrintMatrix(resultMatrix);