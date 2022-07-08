//`24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// // for(int i = 1; i<=A; i++)sum+=i;
// int i =1;
// while(i<=A)
// {
//     sum+=i;
//     i++;
// }
// Console.WriteLine($"Сумма чисел от 1 до {A} = {sum}");

// 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Введите число: ");
// string number = Console.ReadLine();
// int num;
// Console.WriteLine(int.TryParse(number, out num));
// int size = 0;
// for (int i = 0; i < number.Length; i++)
//     size++;
// Console.WriteLine($"В числе {number} - {size} цифр");


// 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// int N = Convert.ToInt32(Console.ReadLine());
// int factorial = 1;
// for(int i = 1; i <= N; i++) factorial*=i;
// Console.WriteLine($"{N}! = {factorial}");

// 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
// for (int i =0 ; i<array.Length;i++)
// Console.Write($"{array[i] = new Random().Next(0,2)}");

//int[] array = GetBinaryArray(8);
// Console.Write($"[{string.Join("; ", array)}]");
// int[] GetBinaryArray(int size)
// {
//     int[] resultArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         resultArray[i] = new Random().Next(2);
//     }
//     return resultArray;
// }


//======Домашнее задание

//25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Задача 25: ");
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());
int i = 2;
int sqrt = A;
while (i<=B)
{
    sqrt = sqrt*A;
    i++;
}
Console.WriteLine($"{A}^{B}={sqrt}");

//27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Задача 27: ");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int numberHulf = number;
while(number>0)
{
    number = numberHulf%10;
    numberHulf/=10;
    sum = sum+number;
}
Console.WriteLine($"Сумма цифр = {sum}");

//29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Задача 29: ");
int[] array = new int[8];
for (int j =0 ; j<array.Length;j++)
Console.Write($"{array[j] = new Random().Next()}; ");
