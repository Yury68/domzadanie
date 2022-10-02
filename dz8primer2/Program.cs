//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 1, 9);
PrintArray(array);
Console.WriteLine();
NumbersArray(array);
Console.Write(String.Join(",",NumbersArray(array))); //для проверки вывел
Console.WriteLine();
Console.Write("Номер строки с наименьшей суммой элементов: ");
MinSum(NumbersArray(array));
Console.Write("-я строка");

int[,] GetArray(int m, int n, int minvalue, int maxvalue)
{
    int[,] resarray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resarray[i, j] = new Random().Next(minvalue, maxvalue + 1);
        }
    }
    return resarray;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
//пишем метод, который посчитает суммы строк
int[] NumbersArray(int[,] arr)
{
    int[] resarr = new int[arr.GetLength(0)];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int sum = 0;
            resarr[i] = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {      
                sum = sum + arr[i,j];
                resarr[i] = sum;               
            }
        }
    return resarr;
}
//найдем минимальное значение и выпишем его индекс
int MinSum(int[] arr)
{
    int index = 1;
    int min = arr[0];
    for( int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
        min = arr[i];
        index = i + 1;
        }
    }
    Console.Write(index);
    return index;
}