﻿// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
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



//12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.



//14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

/*bool IsMultiplicity(int number)
{
    return(number % 7 == 0&& number %23 ==0);
}
Console.WriteLine(IsMultiplicity());
*/