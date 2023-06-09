﻿//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка

Console.Write("Напиши высоту массива - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Напиши ширину массива - ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

void mas(int m, int n)
{
    int i,j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            randomArray[i,j] = rand.Next(1,9);
        }
    }
}

void printm(int[,] array)
{
    int i,j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

mas(m,n);
Console.WriteLine("\nМассив получился вот таким - ");
printm(randomArray);

// ниже считается сумма элементов в строке
int SumLine(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
    return sum;
}

// а вот тут сравниваем суммы по строчкам, и находим наименьшую
int minSum = 1;
int sum = SumLine(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
{
    if (sum > SumLine(randomArray, i))
    {
        sum = SumLine(randomArray, i);
        minSum = i+1;
    }
}

// тут выводим номер строки с наименьшей суммой
Console.WriteLine($"\nСтрока c минимальной суммой элементов - {minSum}");