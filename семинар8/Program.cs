// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//  int[,] array = new int[m, n];
//  for (int i = 0; i < m; i++)
//      {
//  for (int j = 0; j < n; j++)
//          {
//  array[i, j] = new Random().Next(min, max + 1);
//         }
//      }
//  return array;
//  }

//  void ShowArray(int[,] array)
//  {

//  for (int i = 0; i < array.GetLength(0); i++)
//      {
//  for (int j = 0; j < array.GetLength(1); j++)
//          {
//  Console.Write(array[i, j] + " ");
//          }
//  Console.WriteLine();
//      }

//  }

// void Checking(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, j] < array[i, k])
//                 {
                    
//                     array[i, j] = array[i, k];
                    
//                 }
//             }
//         }
//     }
// }


// Console.Clear();

// Console.Write("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число-минимум: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число-максимум: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandomArray(rows, columns, min, max);

// ShowArray (array);
// Checking (array);
// Console.WriteLine();
// ShowArray (array);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandomArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max  + 1);
        }
    }
    return array;
}

void ShowArray(int[,] array, string nameArray)
{
    Console.WriteLine($"{nameArray}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultiplicateMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Матрицы невозможно перемножить");
    }
    else
    {
        int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    matrixResult[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        ShowArray(matrixResult, "Результат: ");
    }
}

Console.Clear();

Console.Write("Введите число строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов первой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число-минимум: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число-максимум: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateRandomArray(rows1, columns1, min, max);
int[,] matrix2 = CreateRandomArray(rows2, columns2, min, max);

ShowArray(matrix1, "Исходная матрица 1:");
ShowArray(matrix2, "Исходная матрица 2:");
MultiplicateMatrix(matrix1, matrix2);