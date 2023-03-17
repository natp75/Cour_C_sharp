// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int N, int start, int end)
{
    double[] RandomArray = new double[N];
    for (int i=0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double[] Array = CreateRandomArray(4, -6, 10);
double min = Array[0];
double max = Array[0];
{
    ShowArray(Array);
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] < min)
                min = Array[i];
            if (max < Array[i])
                max = Array[i];
        }
        Console.WriteLine($"Min = {min}");
        Console.WriteLine($"Max = {max}");
        Console.WriteLine($"Разность Max и Min = {max - min}");
}
