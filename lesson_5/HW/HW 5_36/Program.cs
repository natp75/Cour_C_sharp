// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях


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

int[] Array = CreateRandomArray(4, 100, 1000);
int sum = 0;
{
    ShowArray(Array);
        for (int i = 0; i < Array.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum = sum + Array[i];
            }
        }
        Console.WriteLine(sum);
}