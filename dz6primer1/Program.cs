//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введите требуемые числа: ");
int[] Numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
Console.Write(String.Join(", ",Numbers));
Console.Write(" -> ");

int Res = NumPositiveNumb(Numbers);
Console.Write($"{Res} кол-во чисел больше 0");

int NumPositiveNumb(int[] num)
{
    int count = 0;
    for(int i = 0; i < num.Length; i++)
    {
        if(num[i] > 0) 
        count = count + 1;
    }
    return count;
}
