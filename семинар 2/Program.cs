// // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine (num/10 % 10);


// // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Console.Write("Введи число из промежутка от 1 до 1000: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 100) {
//     Console.Write ("третьей цифры нет");
// }
//  if (num > 100) {
//     Console.Write ( num % 10);
//  }
    

// // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введи число недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day==6 || day==7) {
    Console.WriteLine("выходной день");
}
else if (day < 1 || day > 7) {
     Console.WriteLine("некорректный день");
       }
else {
     Console.WriteLine("не выходной день");
        }  

