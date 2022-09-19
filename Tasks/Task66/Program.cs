// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int InputNum(string a)
{
	Console.WriteLine(a);
	return Convert.ToInt32(Console.ReadLine());
}

int SummNaturalNumbers(int start, int finish)
{
	if (start == finish) return finish;
	int summ = start;
	start++;
	return summ + SummNaturalNumbers(start, finish);
}


int numStart = InputNum("Введите значение M: ");
int numFinish = InputNum("Введите значение N: ");
Console.WriteLine("Сумма натуральных элементов в промежутке от M до N: ");
Console.WriteLine(SummNaturalNumbers(numStart, numFinish));
