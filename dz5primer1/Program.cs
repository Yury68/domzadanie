//Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.Clear();
Console.Write("Введите нужный размер массива: ");
int rm = int.Parse(Console.ReadLine());

int[] Array = M(rm, 100, 1000);
Console.Write("[");
Console.Write(String.Join(",",Array));
Console.Write("] -> ");

int kolchch = Res(Array);
Console.Write(kolchch);

int[] M(int size, int a, int b)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    return arr;
}

int Res(int [] arr)
{
    int count = 0;
    foreach (int a in arr)
    if(a % 2 == 0) 
    count = count + 1;
    return count;
}
