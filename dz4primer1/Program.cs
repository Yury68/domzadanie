//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//Console.OutputEncoding = System.Text.Encoding.Unicode;спросить у ребят (у Макса), 
//какэто работает, конвертировать наверно по другому надо
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int B = int.Parse(Console.ReadLine());

int Avstep(int x, int n)
{
    int res = 1;
    for (int i = 1; i <= n; i++)
    {
         res = res * x;
    }
    return res;
}
Console.Write($"{A}, {B} -> {Avstep(A, B)}");//{A}{UpString(B)} цифру "В" должно в 
//верхний регистр закинуть, типа степень показать