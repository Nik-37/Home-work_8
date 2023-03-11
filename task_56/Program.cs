/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
/// 
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

//1. Заполним матрицy
int[,] resultMatrix = GetMatrix(3,5,0,5);

//2. Напечатаем матрицу
PrintMatrix(resultMatrix);

int iMin = 0; //индекс мин элемента
int sumMin = Int32.MaxValue; // мин сумма

for(int i = 0; i < resultMatrix.GetLength(0); i++)
{
  int rowSum = 0; //переменная подсчета суммы в строке

  for(int j = 0; j < resultMatrix.GetLength(1); j++)
  {
    rowSum+= resultMatrix[i,j];
  }

  //проверка, является ли сумма строки минимальной среди обработанных ранее 
  if(rowSum < sumMin)
  {
    //запомним новый минимум и индекс этой строки
    sumMin = rowSum;
    iMin = i;
  }
}

Console.WriteLine("Строка с наименьшей суммой элементов =  " + iMin);