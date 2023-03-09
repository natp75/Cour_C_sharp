// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int Division(int number)
{
    if (number < 10)
        return number;
    int end = number % 10;
    int nextNumber = number / 10;
    return end + Division(nextNumber);
}

int myNumber = new Random().Next(1, 300);
Console.WriteLine($"Число = {myNumber}");
int result = Division(myNumber);
Console.WriteLine($"Сумма чисел = {result}");
