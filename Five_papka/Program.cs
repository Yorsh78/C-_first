﻿Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
if (number>=100&&number<1000)
{
    Console.Write("Последняя цифра числа - " + number%10);
}