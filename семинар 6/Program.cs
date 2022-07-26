Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] MyArray = CreateRandomArray(6);
ShowArray(MyArray);

int Checking (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

Checking(MyArray);

Console.WriteLine($"Введено чисел больше 0: {Checking(MyArray)} ");



Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.Write ("Введи значение k1 для первой прямой: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введи значение k2 для второй прямой: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введи значение b1 для первой прямой: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введи значение b2 для второй прямой: ");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 != b2)
    Console.WriteLine("прямые параллельны");
else
        if (k1 == k2 && b1 == b2)
    Console.WriteLine("прямые совпадают");
     else
        {
            int x = (b2 - b1)/(k1 - k2);
            int y = k1*x + b1;
            Console.WriteLine($"Координаты точки пересечения прямых: x : {x} | y : {y}");
        }
