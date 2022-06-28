/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int squareNumber = number * number;
Console.Write("Квадрат числа равен: " + squareNumber);
*/

//1.Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

/*Console.Write("введите 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number2*number2 == number1)
{
 
    Console.Write("квадрат " + number2);
    Console.Write(" = " + number1);
}
else
{
    Console.Write(number2);
    Console.WriteLine(" не является квадратом " + number1);
}
*/

//3.Напишите программу, которая будет выдавать название дня недели по заданному номеру.
/*
Console.Write("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (1<= dayNumber && dayNumber <= 7)
{
    if (dayNumber == 1)
    {
        Console.Write("понедельник");

    }
    if (dayNumber == 2)
    {
        Console.Write("вторник");

    }
    if (dayNumber == 3)
    {
        Console.Write("среда");

    }
    if (dayNumber == 4)
    {
        Console.Write("четверг");

    }
    if (dayNumber == 5)
    {
        Console.Write("пятница");

    }
    if (dayNumber == 6)
    {
        Console.Write("суббота");

    }
    if (dayNumber == 7)
    {
        Console.Write("воскресенье");

    }
}
else
{
    Console.Write("нужно ввести от 1 до 7");
}
*/
//5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*Console.Write("N: ");
int N = Convert.ToInt32(Console.ReadLine());

int negN = N * (-1);
while (negN <= N)
{
    Console.WriteLine(negN);
    negN++;
}
*/

//7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
/*
int num = new Random().Next(100, 1000);
Console.WriteLine("3-х значное число - " + num);
num = num % 10;
Console.Write("последняя цифра числа - " + num);
*/



//Домашнее задание
//2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Максимальное и минимальное");
Console.Write("Введите первое число: ");
int or1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int or2 = Convert.ToInt32(Console.ReadLine());
if (or1 > or2)
{
    Console.WriteLine("Большее - " + or1);
    Console.WriteLine("Меньшее - " + or2);
}
if (or1 < or2)
{
    Console.WriteLine("Большее - " + or2);
    Console.WriteLine("Меньшее - " + or1);
}
else
{
    Console.WriteLine("числа равны ");
}

//4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Максимальное из 3-х чисел");
Console.Write("Введите первое число: ");
int max1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int max2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int max3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (max1 != max2 ^ max1 != max3 ^ max3 != max2)
{
    if (max1 > max2)
    {
        max = max1;
    }
    else
    {
        max = max2;
    }
    if (max > max3)
    {
        Console.WriteLine("Макссимальное число - " + max);
    }
    else
    {
        max = max3;
        Console.WriteLine("Макссимальное число - " + max);
    }
}
else
{
    Console.WriteLine("Пожалуйста, запустите программу заново и ВВЕДИТЕ РАЗНЫЕ ЧИСЛА!");
}

//6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Принадлежность к четным числам");
Console.Write("Введите число: ");
int even = Convert.ToInt32(Console.ReadLine());
if (even % 2 == 0)
{
    Console.Write("число " + even);
    Console.WriteLine(" - четное");
}
else
{
        Console.Write("число " + even);
        Console.WriteLine(" - не четное");
}

//8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Четные числа от 1 до N");
Console.Write("Введите число: ");
int evenN = Convert.ToInt32(Console.ReadLine());
int countN = 2;
while (countN <= evenN)
{
    Console.WriteLine(countN);
    countN += 2;
}