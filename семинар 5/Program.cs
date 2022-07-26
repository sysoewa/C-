// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int [] CreateRandomArray (int size){
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next (100,1000);
//     }
//     return array;
// }


// void ShowArray(int[] array)
// {
//     Console.WriteLine();
//     Console.Write("Исходный массив: [");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write($"{array[array.Length - 1]}]");
//     Console.WriteLine();
// }

// void Numbers (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count++;
//     }

//     Console.Write($"Количество четных элементов в массиве: {count}");
// }

// int[] AskUser()
// {
//     Console.Write("Введите размер массива: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] array = CreateRandomArray(size);
//     ShowArray(array);

//     return array;
// }

// Numbers(AskUser());



// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int [] CreateRandomArray (int size) 
// {
//     int [] array = new int [size];
//     for (int i=0; i < size; i++) 
//     {
//         array [i] = new Random().Next (0, 20);
//     } 
//     return array;
// }


// void ShowArray (int [] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array [i] + " ");
//     }
// }

// int [] MyArray = CreateRandomArray (6);
// ShowArray (MyArray);


// void Sum (int [] array) {
//     int result = 0;
//     for (int i = 1; i < array.Length; i = i + 2)
//     {
//         result = result + array [i];
//     }
//     Console.WriteLine("Сумма чисел, стоящих на нечётных позициях в массиве: " + result);
// }

// Sum (MyArray);



// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int [] CreateRandomArray(int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 20);
    }
    return array;
}


void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int [] MyArray = CreateRandomArray(6);
ShowArray(MyArray);



void DifMinMax(int [] array)
{
    int max = 0;
    int min = array[0];
    int result  = 0;
    


    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        
    }

    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    Console.WriteLine ("max number: " + max + "min number: " + min );
    result = max - min;
    Console.WriteLine("difference between min and max: " + result );
}

DifMinMax (MyArray);


