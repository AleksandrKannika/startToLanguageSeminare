// 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] array = new int[12];
// int size = array.Length;
// int resultPositive = 0;
// int resultNegative = 0;
// int index = 0;
// while (index < size)
// {
//     array[index] = new Random().Next(-9, 10);
//     index++;
// }
// Console.WriteLine($"[{String.Join("; ", array)}]");
// for (int startIndex = 0; startIndex < size; startIndex++)
// {
//     if (array[startIndex] > 0)
//     {
//         resultPositive += array[startIndex];
//     }
//     else
//     {
//         resultNegative += array[startIndex];
//     }
// }
// Console.WriteLine($"Сумма положительных цифр = {resultPositive}");
// Console.WriteLine($"Сумма отрицательных цифр = {resultNegative}");


// 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] arraySwap = new int [10];
// int index = 0;
// int size = arraySwap.Length;
// while(index<size)
// {
//     arraySwap[index] = new Random().Next(-9,10);
//     index++;
// }
// Console.WriteLine($"[{String.Join("; ",arraySwap)}]");
// int swap = -1;
// for(index = 0;index<size;index++)
// {
//     arraySwap[index]*=swap;

// }
// Console.WriteLine($"[{String.Join("; ",arraySwap)}]");



// 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] arrayFindNumber = new int[10];
// int size = arrayFindNumber.Length;
// for (int index = 0; index < size; index++)
// {
//     arrayFindNumber[index] = new Random().Next(100);
// }
// Console.WriteLine($"[{String.Join("; ", arrayFindNumber)}]");

// int finderNumber = Convert.ToInt32(Console.ReadLine());
// int indexFind = 0;
// while(indexFind<size)
// {
//     if(arrayFindNumber[indexFind]==finderNumber)
//     {
//         Console.WriteLine($"{finderNumber} - есть в массиве");
//         break;
//     }
//     indexFind++;
// }
// Console.WriteLine($"{finderNumber} - нет в массиве");




// 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] bigArray = new int[123];
// int size = bigArray.Length;
// int index = 0;
// while(index<size)
// {
//     bigArray[index] = new Random().Next(1000);
//     index++;
// }
// int countFind = 0;
// int findAll =0;
// while(findAll<size)
// {
//     if(bigArray[findAll]<100 && bigArray[findAll]>9)
//     countFind++;
// findAll++;
// }
// Console.Write(countFind);


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] arrayComposition = { 1, 2, 6, 4, 5 };
// int composition = 0;
// int size = arrayComposition.Length-1;
// for (int i = 0; i <= size; i++)
// {
//     if (arrayComposition[i] == arrayComposition[size])
//     {
//         composition = arrayComposition[i];
//     } 
//     else
//     {
//         composition = arrayComposition[i] * arrayComposition[size];
//     }
//     size--;
//     Console.Write(composition);
// }


//======Домашнее задание

// 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задача 34:");
Console.Clear();
int [] randomArray = new int[10];
int countEvenNumbers = 0;
int size1 = randomArray.Length;
int find =0;
for(int i = 0; i<size1;i++)
{
    randomArray[i] = new Random().Next(100,1000);
    find = randomArray[i]%2;
    if(find==0)countEvenNumbers++;
}
Console.WriteLine($"[{String.Join("; ", randomArray)}]");
Console.WriteLine($"{countEvenNumbers} - четных чисел, в текущем массиве!");

// 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задача 36:");
int[] array = new int[10];
int size2 = array.Length;
int notEvenElement = 0;
int sumNotEvenElement = 0;
for (int i = 0; i < size2; i++)
{
    array[i] = new Random().Next(-99,100);
    notEvenElement = i%2;
    if(notEvenElement!=0)
    {
        sumNotEvenElement = sumNotEvenElement+array[i];
    }
}
Console.WriteLine($"[{String.Join("; ", array)}]");
Console.WriteLine($"{sumNotEvenElement} - сумма не четных елементов, в текущем массиве!");


// 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задача 38:");
double[] arrayMM = { 2.2, 43.2, 6.32, 98.3, 5.45 };
int size3 = array.Length;
double maxNumber = array[0];
double minNumber = array[1];
for (int i = 0; i < size3; i++)
{
    if (array[i] > maxNumber) maxNumber = array[i];
    if (array[i] < minNumber) minNumber = array[i];
}
Console.WriteLine($"[{String.Join("; ", arrayMM)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {maxNumber - minNumber}");