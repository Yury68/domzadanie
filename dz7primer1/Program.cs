// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int minvalue, int maxvalue)
{
    double[,] resarray = new double[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            resarray[i, j] = Math.Round((new Random().Next(minvalue, maxvalue)
            + new Random().NextDouble()), 1);// только вот при такой конструкции
            //у нас никогда не получается целых чисел почему-то, если два знака
            //после запятой или больше, а если один знак, то бывают            
            if(resarray[i, j] == maxvalue) resarray[i, j] = maxvalue;//а это чтобы
            // max могло сгенерироваться иногда, а если ставим max+1,
            // то числа генерируются до max,9.
        }
    }
    return resarray;
}

void PrintArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{ arr[i, j]} ");
        }
        Console.WriteLine();
    }
}