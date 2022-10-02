// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array1 = GetArray(rows, columns, 2, 4);// цифры убавил, чтоб посчитать легче
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(rows, columns, 2, 4);
PrintArray(array2);
Console.WriteLine();
PrintArray(MultiplyingArray(array1, array2));

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
//пишем метод для перемножения двух массивов
int[,] MultiplyingArray(int[,] arr1, int[,] arr2)
{
    int[,] resarray = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for(int i = 0; i < arr1.GetLength(0); i++)
    {
        for(int j = 0; j < arr2.GetLength(1); j++)
        {
            for(int k = 0; k < arr1.GetLength(0); k++)
            {
                resarray[i,j] += arr1[i,k] * arr2[k, j];//вот этот += первый раз вижу,
                // и без него не получается сделать, и наверно это способ только для
                //квадратных массивов.
            }
        }
    }
    return resarray;
}