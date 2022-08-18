﻿// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
int[] array = new int[12];

Random rand = new Random();
int sumP = 0; //сумма положительных
int sumN = 0; //Сумма отрицательных
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
    if (array[i] > 0)
    {
        sumP += array[i];
        // sumP = sumP + array[i];
    }
    else
    {
        sumN += array[i];
    }
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"сумма положительных {sumP}");
Console.WriteLine($"Сумма отрицательных {sumN}");