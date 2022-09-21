//Задача 43: Напишите программу, которая найдёт 
//точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.Write("Введите через пробел значеня b1,k1,b2,k2: ");
double[] input = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
// double.Parse вроде норм работает. это хорошо 

//Console.Write(String.Join(", ", coord)); так не получается 
//наименования значений распечатать
PrintArray(input);
CoordinateIntersectionPoint(input);
void PrintArray(double[] ar)
{
        Console.Write($"b1 = {ar[0]}, k1 = {ar[1]}, b2 = {ar[2]}, k2 = {ar[3]} -> ");
}
void CoordinateIntersectionPoint(double[] ar)// придется потихоньку английский 
//                                              осваивать
{
    double x = 0;
    double y = 0;
    x = (ar[2] - ar[0])/(ar[1] - ar[3]);
    y = Math.Round(ar[1]*x + ar[0], 2);//значит кол-во цифр после запятой можно 
    //и сразу в решении и после решения готовый рез-т корректировать
    x = Math.Round(x, 3);
    Console.Write($"({x}; {y}) - точка пересечения двух прямых");
}