// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//[1, 7] -> такого числа в массиве нет
Console.Clear();
Console.Write("Введите позицию строки (начиная с 0): ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите позицию столбца (начиная с 0): ");
int column = int.Parse(Console.ReadLine());


 int[,] arr = new int[3,4]{{1,4,7,2},{5,9,2,3},{8,4,2,4}};//допинал, вывел в консоль нужный массив
 PrintArray(arr);

 if(row < 3 && column < 4)
     Console.WriteLine($"[{row}, {column}] -> число с такими индексами {arr[row,column]}");
 else
     Console.WriteLine($"[{row}, {column}] -> числа с такими инжексами в массиве нет");

    // а ниже стандартное решение, размерность задаем "a" и "в", числа от 1 до 10
//int a = 5;
//int b = 5;
//int[,] array = GetArray(a, b, 1, 10);
//PrintArray(array);

// if(row < a && column < b)
//     Console.WriteLine($"[{row}, {column}] -> число с такими индексами {array[row,column]}");
// else
//     Console.WriteLine($"[{row}, {column}] -> числа с такими инжексами в массиве нет");

// int[,] GetArray(int m, int n, int minvalue, int maxvalue)
// {
//     int[,] resarray = new int[m,n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             resarray[i, j] = new Random().Next(minvalue, maxvalue + 1);
//         }
//     }
//     return resarray;
// }

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}
