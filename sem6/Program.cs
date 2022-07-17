// int[] array = GetArray(10,0,10);
// Console.WriteLine(string.Join(" ",array));

// int[] reversArray = ReverseCopyArray(array);
// Console.WriteLine(string.Join(" ",reversArray));

// ReverseArray(array);
// Console.WriteLine(string.Join(" ",array));


// int[] GetArray(int size,int minValue, int maxValue)
// {
//     int[]res  = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue,maxValue+1);
//     }
//     return res;
// }

// void ReverseArray(int[]inputArray)
// {
//     for (int i = 0; i < inputArray.Length/2; i++)
//     {
//         int temp = inputArray[i];
//         inputArray[i] = inputArray[inputArray.Length -i -1];
//         inputArray[inputArray.Length -i -1] = temp;
//     }
// }

// int[] ReverseCopyArray(int[]inputArray)
// {
//     int[] result = new int[inputArray.Length];
//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         result[i]= inputArray[inputArray.Length - i - 1];
//     }
//     return result;
// }


//40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// int firstSide = 5;
// int secondSide = 3;
// int thirdSide = 4;
// if (firstSide + secondSide > thirdSide && secondSide + thirdSide > firstSide && thirdSide + firstSide > secondSide)
// {
//     Console.WriteLine($"Треугольник со сторонами A = {firstSide}, B = {secondSide} и C = {thirdSide} может сучществовать");
// }
// else Console.WriteLine($"Треугольника со сторонами A = {firstSide}, B = {secondSide} и C = {thirdSide} не существует");

// 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// int firstNumber = 0;
// int secondNumber = 1;

// Console.WriteLine(firstNumber);
// Console.WriteLine(secondNumber);

// for (int i = 3; i <= N; i++)
// {
//     int nextNumber = firstNumber + secondNumber;
//     Console.WriteLine(nextNumber);
//     firstNumber = secondNumber;
//     secondNumber = nextNumber;
// }

// 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// void Binary(int number)
// {
//     string result = "";
//     while(number>0)
//     {
//         result = number%2 + result;
//         number/=2;
//     }
//     Console.Write(result);
// }

// int inputNumber = Convert.ToInt32(Console.ReadLine());
// Binary(inputNumber);


//41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3



Console.Write("Введите 5 чисел: ");
int[] arrayUser = new int[5];

int aboveZero = 0;
int i;
for (i = 0; i < 5; i++)
{
    arrayUser[i] = Convert.ToInt32(Console.ReadLine());
    if (arrayUser[i] > 0) aboveZero++;
}
Console.Write(string.Join(" ", arrayUser));
Console.WriteLine();
Console.WriteLine($"Больше 0 - {aboveZero} чис(ло/ел/ла)");

//43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("введите первую координату первой прямой: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите вторую координату первой прямой: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите первую координату второй прямой: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите вторую координату второй прямой: ");
int b2 = Convert.ToInt32(Console.ReadLine());

int x = 0;
int y = 0;
if (k1 != k2)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
}
else
{
    Console.WriteLine("прямые параллельны");
}
Console.WriteLine($"Точка пересечения двух прямых({x}, {y})");