// 47 задача. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

// }

// int[,] myArray = CreateRandomArray(5, 4, 1, 20);
// ShowArray(myArray);





// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Write("Введи количество строк: ");

// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// Console.Write("Введите значение элемента: ");
// int element = Convert.ToInt32(Console.ReadLine());

// if (FindElement(array, element))
// {
//     Console.WriteLine("Элемент найден");
// }
// else
// {
//     Console.WriteLine("Элемент не найден");
// }


// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }


// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }

// bool FindElement(int[,] array, int element)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == element) return true;
//         }
//     }
//     return false;
// }


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.Write("Введите кол-во строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows,columns,0,10);
PrintArray(array);

double[] averageColumns = GetResultArray(array);
Console.WriteLine($"Среднее арифмитическое каждого столбца = {String.Join(";",averageColumns)}");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max+1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}");
        }
        Console.WriteLine();
    }
}
double[] GetResultArray(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int column = 0; column < array.GetLength(1); column++)
     {
        double sum = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            sum += array[row,column];
        }
        result[column] = Math.Round(sum/array.GetLength(0),2);
    }
    return result;
}