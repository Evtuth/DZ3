//Задача 23
//Напишите программу, которая
//принимает на вход
//число (N)
//и выдает таблицу кубов чисел от 1 до N.
//3 -> 1 8 27
//5 -> 1 8 27 64 125

Console.Write("Введите любое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
int x = 0;

while (count <= N)
{
    x = count * count * count;
    Console.Write(x + " ");
    count++;
}
