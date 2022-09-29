// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
Console.Write("Введите  неотрицательное число m: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int b = int.Parse(Console.ReadLine());

Console.Write($"m = {a}; n = {b} -> A(m,n) = ");

Console.Write(Akker(a,b));

int Akker(int m, int n)
{
    if(m == 0)
    return (n + 1);

    if(m > 0 && n == 0)
    return Akker(m - 1, 1);

    else
    return Akker((m - 1), Akker(m, (n -1)));
}
//только вот незадача, при m=4 не хочет считать уже, переполняется