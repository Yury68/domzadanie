// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Clear();
Console.Write("Введите кол-во строк: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите глубину массива: ");
int z = int.Parse(Console.ReadLine());

int[,,] array = GetArray(x, y, z, 10, 50);
PrintArray(array);
//Console.WriteLine();
//IndexArray(array);
int[,,] GetArray(int a, int b, int c, int minvalue, int maxvalue)
{
    int[,,] resarray = new int[a, b, c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)       
            {
                resarray[i, j, k] = new Random().Next(minvalue, maxvalue + 1);
            }
        }
    }
    return resarray;
}

void PrintArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)//и последним на следующую ""страничку""
    {
        for (int i = 0; i < arr.GetLength(0); i++)//потом на следующую строку перейти
        {
        Console.WriteLine();// чтобы в строку вывести
            for (int j = 0; j < arr.GetLength(1); j++)// чтоб сначала столбец поменять
        
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
//пишем метод вывода с инлексами. только зачем я его писал???
//в принтовом методе все делается легко и просто, выдумываю тут сижу
// int[,,] IndexArray(int[,,] arr)
// {
//     int[,,] resarr = new int[arr.GetLength(0), arr.GetLength(1), arr.GetLength(2)];
//     for (int k = 0; k < arr.GetLength(2); k++)
//     {       
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {    
//             Console.WriteLine();
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 resarr[i, j, k] = arr[i, j, k];
//                 Console.Write($"{resarr[i, j, k]} ({i}, {j}, {k}) ");
//             }
//         }
//     }
//     return resarr;
// }
