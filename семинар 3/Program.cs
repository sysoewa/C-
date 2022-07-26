
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Console.Write("Введите 5-значное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int count1 = Convert.ToInt32(Console.ReadLine());
// int count2 = Convert.ToInt32(Console.ReadLine());
// int count3 = Convert.ToInt32(Console.ReadLine());
// int count4 = Convert.ToInt32(Console.ReadLine());
// int count5 = Convert.ToInt32(Console.ReadLine());

// count1 = num / 10000;
// count2 = num /1000 % 10;
// count3 = num /100 % 10;
// count4 = num % 100;
// count5 = num % 10;

// if  (count1 == count5)  {
//     Console.Write ("1 и 5 числа равны");
// }
// else {
//     Console.Write ("1 и 5 числа не равны");
// }
// if  (count2 == count4) {
//     Console.Write ("2 и 4 числа равны");
// }
// else {
//     Console.Write ("2 и 4 числа не равны");
// }

// Console.WriteLine("num");



// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Clear();
// double distAB (int x1, int y1, int z1, int x2, int y2, int z2) {
//     return Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
// }
// Console.WriteLine("Введите координату x1: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y1: ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z1: ");
// int zA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату x2: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y2: ");
// int yB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z2: ");
// int zB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Длина отрезка"+ distAB(xA, yA, zA, xB, yB, zB));


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.Clear();
void listSqrt (int n) {

    Console.Write (n + "-> ");
    int count = 1;
    while (count <= n) {
        Console.Write(Math.Pow (count, 3)+ ", ");
        count++;
    }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

listSqrt(num);

