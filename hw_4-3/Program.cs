﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Write("[ ");
int[]array = new int[8];
int index = 0;
while (index<8)
{
    array[index] = new Random().Next(0,100);
    Console.Write(array[index]+ " ");
    index++;
}

Console.Write("]");
Console.WriteLine();
