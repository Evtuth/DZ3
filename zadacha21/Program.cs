//Задача 21
//Напишите программу, которая
//принимает на вход
//координаты двух точек
//и находит расстояние между ними в 3D пространстве.
//A (3, 6, 8); B (2, 1, -7) -> 15.84
//A (7, -5, 0); B (1, -1, 9) -> 11.53

Console.Write("Введите координату Хa: ");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Ya: ");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Za: ");
int Za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Xb: ");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Yb: ");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Zb: ");
int Zb = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((Xb) - (Xa), 2) + Math.Pow((Yb) - (Ya), 2) + Math.Pow((Zb) - (Za), 2));

Console.Write("Расстояние равно: " + Math.Round(d, 2));
