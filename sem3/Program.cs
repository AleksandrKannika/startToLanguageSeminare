//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*int x = Convert.ToInt32(Console.ReadLine());

int y = Convert.ToInt32(Console.ReadLine());

if (x>0&&y>0)
{
    Console.WriteLine("Четверть #1");
}
if (x<0&&y>0)
{
    Console.WriteLine("Четверть #2");
}
if (x<0&&y<0)
{
    Console.WriteLine("Четверть #3");
}
if (x>0&&y<0)
{
    Console.WriteLine("Четверть #4");
}
*/

//18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
//Решение в группах задач:

/*Console.WriteLine("Введите номер четверти от 1 до 4:");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1)
{
    Console.WriteLine("x>0 , Y>0");
}
if (n == 2)
{
    Console.WriteLine("x<0 , Y>0");
}
if (n == 3)
{
    Console.WriteLine("x<0 , Y<0");
}
if (n == 4)
{
    Console.WriteLine("x>0 , Y<0");
}
*/

//21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

/*
Console.WriteLine("введите - x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите - y1");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите - x2");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите - y2");
int y2 = Convert.ToInt32(Console.ReadLine());

//AB = √(xb - xa)2 + (yb - ya)2
double n = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
Console.WriteLine($"расстояние между точками: {Math.Round(n)}");
*/

//22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

//1способ
/*
Console.WriteLine("введдите число:");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a <= n)
{
    Console.WriteLine($"{a} = {a*a}");
    a++;
}
*/

// 2способ
/*
Console.WriteLine("введдите число:");
int n = Convert.ToInt32(Console.ReadLine());
for (int a = 1; a <= n; a++)
{
Console.WriteLine($"{a} = {a*a}");
}
*/

//Домашнее задание
/*19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();
Console.WriteLine("1 Задача.");
int x = new Random().Next(10000, 100000);
int b = x % 10;
int a = x / 10000;
if (b == a)
{
    b = (x / 1000) % 10;
    a = (x % 100) / 10;
    if (b == a)
    {
        Console.WriteLine($"{x} - является палиндромом");
    }
    else
    {
    Console.WriteLine($"{x} - не является палиндромом");
    }
}
else
{
    Console.WriteLine($"{x} -  не является палиндромом");
}


/*21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("2 Задача.");
int x1 = new Random().Next(-10, 10);
int y1 = new Random().Next(-10, 10);
int z1 = new Random().Next(-10, 10);
Console.WriteLine($"Точка A ({x1},{y1},{z1})");
int x2 = new Random().Next(-10, 10);
int y2 = new Random().Next(-10, 10);
int z2 = new Random().Next(-10, 10);
Console.WriteLine($"Точка B ({x2},{y2},{z2})");;
double distance = Math.Sqrt(Math.Pow(x1 - y1 - z1, 2) + Math.Pow(x2 + y2 + z2, 2));
Console.WriteLine($"Расстояние между точками - {Math.Round(distance)}");


/*23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("3 Задача.");
Console.Write($"Введите число: ");
int ddd = Convert.ToInt32(Console.ReadLine());
for(double c =1; c<=ddd; c++)
{
    Console.WriteLine($"{c} = {Math.Pow(c,3)}");
}
