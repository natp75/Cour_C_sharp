// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i=0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] Array = CreateRandomArray(8, -9, 9);
{
ShowArray(Array);
}
