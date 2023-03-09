// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int number = new Random().Next(1, 100);
Console.WriteLine(number);
for (int i = 1; i <= 101; ++i)
{
    Console.Write($"{i * i * i}, ");
}