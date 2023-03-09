// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координату x1: ");
double x1 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите координату z1: ");
double z1 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите координату x2: ");
double x2 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите координату y2: ");
double y2 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите координату z2: ");
double z2 = Convert.ToDouble (Console.ReadLine());
double sum = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2);
double len = Math.Sqrt(sum);
string result = string.Format("{0:f2}", len);
Console.WriteLine($"A({x1}, {y1}, {z1}), B({x2}, {y2}, {z2}) -> {result}");
