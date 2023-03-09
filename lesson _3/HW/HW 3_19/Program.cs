// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int number = new Random().Next(10,10000000);
        Console.WriteLine(number);
        string str = number.ToString();
        int len = str.Length;
        for (int i = 0; i < len / 2; ++i)
        {
            if (str[i] != str[len - i - 1])
            {
                Console.WriteLine($"{str} -> нет");
            }
            else
            {
                Console.WriteLine($"{str} -> да");
            }
        }