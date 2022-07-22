//  Задайте значение N. 
//Напишите программу, которая выведет 
//все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// int N = Convert.ToInt32(Console.ReadLine());
// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + "," + PrintNumbers(start + 1, end));
// }
// Console.WriteLine(PrintNumbers(1,N));

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"



// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int number = Convert.ToInt32(Console.ReadLine());
// int SummNumbers(int number)
// {
//     if (number==0)return 0;
//     return (number%10 + SummNumbers(number/10));    
// }
// Console.WriteLine(SummNumbers(number));


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int number = Convert.ToInt32(Console.ReadLine());
// int stepen = Convert.ToInt32(Console.ReadLine());
// int NumberStepen(int first, int second)
// {
//     if (second== 0)return 1;
//     return(first*NumberStepen(first,second-1));
// }
// Console.WriteLine(NumberStepen(number,stepen));


//=======Домашнее задание

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

int minNumber = Convert.ToInt32(Console.ReadLine());
int maxNumber = Convert.ToInt32(Console.ReadLine());

string NaturalNumbers(int m, int n)
{
    if(m==n) return n.ToString();
    return ($"{m}, {NaturalNumbers(m+1,n)}");
}
Console.WriteLine(NaturalNumbers(minNumber,maxNumber));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int minElement = Convert.ToInt32(Console.ReadLine());
int maxElement = Convert.ToInt32(Console.ReadLine());

int NaturalNumbers(int n, int m)
{
    if(m==n) return m;
    return (m+NaturalNumbers(m+1,n));
}
Console.WriteLine(NaturalNumbers(minElement,maxElement));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1,Akkerman(m,n-1));

    return Akkerman(m,n); 
}
Console.WriteLine(Akkerman(3,5));