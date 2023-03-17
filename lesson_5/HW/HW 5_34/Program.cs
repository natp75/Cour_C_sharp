// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


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

int[] Array = CreateRandomArray(8, 100, 1000);
int count = 0;
{
    ShowArray(Array);
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] % 2 == 0)
            {
                count += 1;
            }
        }
        Console.WriteLine(count);
}