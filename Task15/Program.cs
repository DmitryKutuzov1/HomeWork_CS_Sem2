﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру от 1 до 7, обозначающую день недели: ");
int day = int.Parse(Console.ReadLine());

if (day > 7)
{
    Console.WriteLine("Неделя состоит всего из семи дней");
    return;
}

if (day == 6 | day == 7)
    Console.WriteLine("Это выходной");

else
    Console.WriteLine("Это не выходной");