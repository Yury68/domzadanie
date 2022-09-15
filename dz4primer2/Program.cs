//Задача 27: Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
Console.Write("Введите число: ");
int N= int.Parse(Console.ReadLine());
int res = 0;

int sum(int a)
{
    while(a > 0)    
{
    res = res + a % 10;
    a = a / 10;
}
    return res;
}
    Console.WriteLine($"{N} -> {sum(N)}");
