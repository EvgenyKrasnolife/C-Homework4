// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Pow(A, B));

