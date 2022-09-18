//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.Clear();
Console.Write("Введите начальное число массива: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите конечное число массива: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите размер массива: ");
int r = int.Parse(Console.ReadLine());

int[] Array = Arr(r, a, b);
Console.Write("[");
Console.Write(String.Join(",",Array));
Console.Write("]");
int Sum = Res(Array);
Console.Write($" -> {Sum} сумма элементов, стоящих на нечетных позициях");

int[] Arr(int size, int d, int e)
{
    int[] ar = new int[size];
    for(int i = 0; i < size; i++)
    {
        ar[i] = new Random().Next(d, e);
    }
    return ar;
}

int Res(int[] arr)
{
    int sum = 0;    
    for(int i = 0; i < arr.Length; i++)
    {
        if(i % 2 == 0)
        sum = sum + arr[i];
    }
    return sum;
}