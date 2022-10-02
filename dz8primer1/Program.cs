// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 1, 9);
PrintArray(array);
Console.WriteLine();
OrderedArray(array);
PrintArray(array);

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
//пишем метод, который упорядочит наши значения
int[,] OrderedArray(int[,] arr)
{
    int[,] resarr = new int[arr.GetLength(0), arr.GetLength(1)];
    
    for (int k = 0; k < arr.GetLength(1); k++)//этот цикл чтоб каждую строку пройти, а то 
//первую строку программа делает, а с остальными строками делает, что хочет
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i, j + 1] > arr[i, j])
                {
                    int t = arr[i, j + 1];//в буфер ложим наше найденное значение
                    arr[i, j + 1] = arr[i, j];//на его место ложим то, с чем сравнивали... ""прошлое""
                    arr[i, j] = t;//на место ""прошлого"" ложим наше найденное нужное
                }
            }
        }
    }
    return resarr;
}