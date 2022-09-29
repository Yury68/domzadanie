// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.Write("Введите число M: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число N, большее чем М: ");
int b = int.Parse(Console.ReadLine());
Console.Write($"M = {a}; N = {b} -> ");

Console.Write(Sum(a,b));

int Sum(int m, int n)
{
    if(m == n)
    return m;// n - тоже работает

    else
    return Sum(m, n - 1) + n;
}