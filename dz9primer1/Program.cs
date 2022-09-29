// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"
Console.Clear();
Console.Write("Введите нужное число: ");
int a = int.Parse(Console.ReadLine());

Console.Write($"N = {a} -> ");
Console.Write(EvenNum(a));

string EvenNum(int n)
{
    if(n == 2)
    return $"{2}";

    if(n % 2 == 0)
    return $"{n}, {EvenNum(n - 2)}";

    else    
    return $"{(n - 1)}, {EvenNum((n - 1) - 2)}";
}
