// Задача 54: 
    // Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // В итоге получается вот такой массив:
    // 7 4 2 1
    // 9 5 3 2
    // 8 4 4 2

Console.WriteLine("введите количество строк");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int[lines, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Sorting(numbers);
Console.WriteLine();
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 10));
        }
    }
}

void Sorting(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Задача 56: 
    // Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7
    // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("введите количество строк");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int[lines, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int minSumLine = 0;
int sumLine = SumLineElements(numbers, 0);
for (int i = 1; i < numbers.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(numbers, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"{minSumLine+1} — строка с наименьшей суммой ({sumLine}) элементов");

int SumLineElements(int[,] numbers, int i)
{
  int sumLine = numbers[i,0];
  for (int j = 1; j < numbers.GetLength(1); j++)
  {
    sumLine += numbers[i,j];
  }
  return sumLine;
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 10));
        }
    }
}



void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Задача 58:
    // Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    // Например, даны 2 матрицы:
    // 2 4 | 3 4
    // 3 2 | 3 3
    // Результирующая матрица будет:
    // 18 20
    // 15 18

Console.Write("Введите количество строк 1 массива: ");
int LinesA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int ColumnsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк 2 массива: ");
int LinesB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int ColumnsB = Convert.ToInt32(Console.ReadLine());
if (ColumnsA != LinesB)
{
  Console.WriteLine("Такие матрицы умножать нельзя!");
  return;
}
    int[,] A = GetArray(LinesA, ColumnsA, 2, 4);
    int[,] B = GetArray(LinesB, ColumnsB, 2, 4);
    PrintArray(A);
    Console.WriteLine();
    PrintArray(B);
    Console.WriteLine();
    PrintArray(GetMultiplicationMatrix(A,B));

    int[,] GetArray(int m, int n, int min, int max)
    {
      int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        result[i, j] = new Random().Next(min, max + 1);
      }
      
    }
      return result;
    }

    void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

    int [,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
    {
      int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
      for (int i = 0; i < arrayA.GetLength(0); i++)
      {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
          for (int k = 0; k < arrayA.GetLength(1); k++)
          {
            arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
          }
        }
      }
      return arrayC;
    }

