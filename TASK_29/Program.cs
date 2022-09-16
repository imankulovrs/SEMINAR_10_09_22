﻿/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/
int size = 8;
int[] array = new int [size];
FillArray(array);
Console.WriteLine("[{0}]", string.Join(" ,", array));

void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
}
