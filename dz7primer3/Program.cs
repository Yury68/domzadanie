//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 1, 9);
PrintArray(array);
Console.Write("Среднее арифметическое каждого столбца: ");
ArithmeticMean(array);
int[,] GetArray(int m, int n, int minvalue, int maxvalue)
{
    int[,] resarray = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            resarray[i, j] = new Random().Next(minvalue, maxvalue + 1);
        }
    }
    return resarray;
}

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
double ArithmeticMean(int[,] arr)
{
    double result = 0;
    for(int j = 0; j < arr.GetLength(1); j++)
    {        
        int sum = 0;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i,j];
            if(i == arr.GetLength(0) - 1)
            result = Math.Round(Convert.ToDouble(sum)/Convert.ToDouble(arr.GetLength(0)), 1);  
        }
        Console.Write($"{result}; ");
    }    
    return result;
}
