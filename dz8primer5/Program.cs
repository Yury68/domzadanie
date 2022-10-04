// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();
Console.Write("Введите кол-во строк (столбцов) квадратного массива: ");
int k = int.Parse(Console.ReadLine());

//так и не смог сделать 01,02 и т.д. а жаль, красивее бы выглядел массив
PrintArray(SpiraleArray(k));

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]}"); 
        }
        Console.WriteLine();
    }
}
int[,] SpiraleArray(int n)
{
    int[,] matrix = new int[n, n];
    int number = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = i; j < n - i; j++)
        {
            matrix[i, j] = number++;
        }
        for (int k = i + 1; k < n - i; k++)
        {
            matrix[k, n - 1 - i] = number++;
        }
        for (int j = n - i - 2; j >= i; j--)
        {
            matrix[n - 1 - i, j] = number++;
        }
        for (int k = n - 2 - i; k > i; k--)
        {
            matrix[k, i] = number++;
        }
    }
    return matrix;
}
