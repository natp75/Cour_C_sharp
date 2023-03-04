// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = new Random().Next(1,10000000);
Console.WriteLine(number);
string str = number.ToString();
if (str.Length < 3)
{
Console.WriteLine("третьей цифры нет");
}
else
{
   int a = (int)Char.GetNumericValue(str[2]);
   Console.WriteLine($"{a}"); 
}
