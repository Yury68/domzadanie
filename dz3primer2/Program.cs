//Задача 21
//Напишите программу, которая принимает на вход
//координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//s= корень из {(xb—xa)2 +(yb—ya)2 +(zb—za)2​}- 2-квадрат
Console.Write("Введите через пробел три координаты первой точки: ");
string[] A = Console.ReadLine().Split( " " );
int x1 = int.Parse(A[0]);
int y1 = int.Parse(A[1]);
int z1 = int.Parse(A[2]);
Console.Write("Введите через пробел три координаты второй точки: ");
string[] B = Console.ReadLine().Split( " " );
int x2 = int.Parse(B[0]);
int y2 = int.Parse(B[1]);
int z2 = int.Parse(B[2]);
double res = Math.Sqrt(Math.Pow(x2 -x1, 2) + 
Math.Pow(y2 -y1, 2) + Math.Pow(z2 - z1, 2));
double Res = Math.Round(res, 2);
Console.Write($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {Res}");