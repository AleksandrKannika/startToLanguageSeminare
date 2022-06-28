// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

/*int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число: {number}"); //Интерполяция - ($)
int digitOne = number / 10;
int digitTwo = number % 10;
Console.WriteLine($"левая цифра: {digitOne}");
Console.WriteLine($"правая цифра: {digitTwo}");
int max = Math.Max(digitOne,digitTwo); //Max(1_значение,2_значение) возвращает большее
Console.WriteLine($"наибольшее из двух чисел: {max}");
*/

//11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int x = new Random().Next(100,1000);
// Console.WriteLine(x);
// x = (x/100)*10 + x%10;
// Console.WriteLine(x);

//12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

int number1 = 2;
Console.WriteLine(number1);
int number2 = 4;
Console.WriteLine(number2);
if (number1 % number2 == 0)
{
    Console.WriteLine($"число {number2} кратно {number1}");
}
else
{
    int number = number2 % number1;
    Console.WriteLine(number);
}


//14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

/*int number = new Random().Next();
Console.WriteLine(number);
bool what(int number)
{
    return(number % 7 == 0&& number %23 ==0);
}
<<<<<<< HEAD
Console.WriteLine(what(number));
*/
 
//Домашнее задание
//10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*Console.Clear();
=======
Console.WriteLine(IsMultiplicity());
*/



//10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
>>>>>>> 8cf2ecd (sem2 Домашнее задание)
Console.WriteLine("2 цифра трехзначного числа");
int N3x = new Random().Next(100, 1000);
Console.WriteLine(N3x);
N3x = (N3x % 100)/10;
Console.WriteLine($"2 цифра - {N3x}");
Console.WriteLine();

//13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Третья цифра заданного числа");
int numX = new Random().Next();
Console.WriteLine(numX);
while(numX>=1000)
{
    numX = numX/10;
}
if (numX <100)
{
Console.WriteLine("3 цифры нет");
}
else
{
    numX = numX%10;
    Console.WriteLine("3 цифра - " + numX);
}
Console.WriteLine();

//15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

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
if (dayNumber == 6 ^ dayNumber == 7)
{
    Console.WriteLine(" - это же выходной день!");
}
else
{
    Console.WriteLine(" - не сегодня");
<<<<<<< HEAD
}
*/
=======
}
>>>>>>> 8cf2ecd (sem2 Домашнее задание)
