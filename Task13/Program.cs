// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int mod = Math.Abs(number);

if (mod < 100)
{
    Console.WriteLine("В этом числе нет третьей цифры");
    return;
}

while (mod > 999)
{
    mod = mod / 10;
}

int digit = mod % 10;
Console.WriteLine($"Третья цифра числа {number} - {digit}");