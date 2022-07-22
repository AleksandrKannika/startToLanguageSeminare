
// int rows = Int32.Parse(Console.ReadLine());
// int columns = Int32.Parse(Console.ReadLine());


// double[,] matrix = new double[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().NextDouble() * 100;
//         Console.Write(matrix[i,j] + "\t"); // t - tab
//     }
//     Console.WriteLine();
// }

// 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] array = new int[4,5];
// for (int i = 0; i < 4; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         array[i,j] = i+j;
//         Console.Write(array[i,j] + "\t");
//     }
//     Console.WriteLine();
// }


// 49: *Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// Console.WriteLine("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine());
// int[,] createArray = new int[rows, columns];


// int[,] PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(11);
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }
// PrintArray(createArray);
// Console.WriteLine();

// int[,] SquareEvenElements(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i%2==0&&j%2==0)
//             array[i,j]*=array[i,j]; 
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }
// SquareEvenElements(createArray);

// 51: Задайте двумерный массив. Найдите элементы, главной диагонали, и сложите эти элементы между собой.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// int[,] NewArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(11);
//             Console.Write(array[i,j] +"\t");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }
// int[,] MainDiagonal(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i==j)
//             array[i,j]*=array[i,j];
//             Console.Write(array[i,j]+"\t");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }
// int[,] matrix = new int[4,4];
// NewArray(matrix);
// Console.WriteLine();
// MainDiagonal(matrix);

//=======Домашнее задание

// 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] RealNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble();
            array[i,j]*=10;
            Console.Write(Math.Round((array[i,j]),1) + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    return array;
}
double[,] newArray = new double[3,3];

RealNumbers(newArray);

// 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(11);
        }
    }
    return array;
}

int[,] PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    return array;
}

void FindElement(int[,] array)
{
    int searchNumber = Convert.ToInt32(Console.ReadLine()); // искомое число
    int element = 0;//позиция в массиве
    if (searchNumber > array.Length || searchNumber < 1)
    {
        Console.Write($"Массив состоит из {array.Length} элементов, пожалуйста выбирите в диапазоне от 1 до {array.Length}");
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                element = element + 1;
                if (searchNumber == element)
                    Console.Write($"На {searchNumber} позиции находится число - {array[i, j]}");
            }
        }
    }
}


int[,] matrix = new int[5, 5];

// 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Average(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    double summ = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        summ = summ+array[j,i];
    }
    Console.Write($"{summ/array.GetLength(0)}");
    if(i==array.GetLength(0)-1)
    {
        Console.Write(".");// конец
    }
    else
    {
        Console.Write("; ");// разделитель
    }
}
}
CreateMatrix(matrix);
PrintMatrix(matrix);
FindElement(matrix); // 50 задача
Console.WriteLine();
Average(matrix); // 52 задача