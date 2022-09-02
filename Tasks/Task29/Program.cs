// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void RandomArray(int[] a){
	Random random = new Random();
	for(int i = 0; i < a.Length; i++){
		a[i] = random.Next(0, 100);
	
	Console.Write(a[i] + " ");
	}
}

int[] array = new int[8];
RandomArray(array);