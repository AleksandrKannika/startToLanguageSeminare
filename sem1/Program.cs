/*
1.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int squareNumber = number * number;
Console.Write("Квадрат числа равен: " + squareNumber);
*/

//2.Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
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
int num = new Random().Next(100, 1000);
Console.WriteLine("3-х значное число - " + num);
num = num % 10;
Console.Write("последняя цифра числа - " + num);