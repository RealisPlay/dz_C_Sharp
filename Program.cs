/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine ("Введите число №1: ");
int Num1 = Convert.ToInt32(Console.ReadLine());;
Console.WriteLine ("Введите число №2: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
if (Num1 > Num2)
{
    Console.WriteLine(Num1);Console.WriteLine("большее");
    Console.WriteLine(Num2);Console.WriteLine("меньшее");
}
else
{
    Console.WriteLine(Num2);Console.WriteLine("большее");
    Console.WriteLine(Num1);Console.WriteLine("меньшее");
}