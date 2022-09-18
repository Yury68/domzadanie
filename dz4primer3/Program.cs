//Задача 29: Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
Console.Clear();
Console.Write("Введите начальное число массива: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите конечное число массива: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите размер массива: ");
int r = int.Parse(Console.ReadLine());

int[] array = m(r, num1, num2);
Console.Write(String.Join(",",array));
Console.Write($" -> [");
int[] arraycopi = CopiArray(array);
Console.Write(String.Join(",",arraycopi));
Console.Write("]");

int[] m(int size, int a, int b)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(a, b + 1);
        //Console.Write($"{res[i]}, ");
    }
    return res;
}
int[] CopiArray(int[] arr)
{
    int[] copiarr = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        copiarr[i] = arr[i]; 
    }
    return copiarr;
    
}
