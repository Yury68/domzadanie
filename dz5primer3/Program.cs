//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.Clear();
Console.Write("Введите начальное число массива: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите конечное число массива: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите размер массива: ");
int r = int.Parse(Console.ReadLine());

int[] Array = Arr(r, a, b);
Console.Write("[");
Console.Write(String.Join(" ",Array));
Console.Write("] -> ");

int res = Diffmaxmin(Array);
Console.Write($"{res}  разница между max и min");

int[] Arr(int size, int c, int d)
{
    int[] ar = new int[size];
    for(int i = 0; i < size; i++)
    {
        ar[i] = new Random().Next(c, d);        
    }
    return ar;
}
int Diffmaxmin(int[] arr)
{
    int min = arr[0];
    foreach(int x in arr)
        if(x < min)
        min = x;
    int max = arr[0];
    foreach(int y in arr)
        if(y > max)
        max = y;
    int diff = 0;
    diff = max - min;
        return diff;  
}       
