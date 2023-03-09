// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int numberA = new Random().Next(1, 10);
Console.WriteLine($"Число А = {numberA}");
int numberB = new Random().Next(1, 10);
Console.WriteLine($"Число B = {numberB}");

int number = 1;
for (int i = 1; i <= numberB; ++i)
{
    number = number * numberA;
}
 Console.WriteLine($"{number}");
