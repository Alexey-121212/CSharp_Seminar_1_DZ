﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4 8 -> 2, 4, 6, 8

int num;
do
{
    Console.WriteLine("Введите число большее 2");
    num = Convert.ToInt32(Console.ReadLine());
} while (num<2);

Console.WriteLine();
Console.WriteLine("Четные числа от 1 до "+num);

for (int i=2; i<=num;i+=2) {
    Console.WriteLine(i);
}


