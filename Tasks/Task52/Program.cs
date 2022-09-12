﻿// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray(int m, int n)
{
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			array[i, j] = new Random().Next(0, 10);
		}
	}
	return array;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}

void Average(int[,] array)
{

	for (int j = 0; j < array.GetLength(1); j++)
	{
		double avg = 0;
		for (int i = 0; i < array.GetLength(0); i++)
		{
			avg += array[i, j];
		}
		avg /= array.GetLength(0);
		Console.WriteLine("среднее арифметическое элементов " + (j + 1) + " столбца: " + avg);
	}
}


int[,] array = FillArray(5, 5);
PrintArray(array);
Average(array);