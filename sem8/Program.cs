// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()); // null - ссылка в пустоту
// Console.Write("Введите количество столбцы массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

/// summary - описание метода
/// m на n: m - кол-во строк, n - кол-во столбцов
/// minValue , maxValue
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)     // Строчки. m = matrix.Getarray.GetLength(0)(0)
//     {
//         for (int j = 0; j < n; j++) // n = matrix.Getarray.GetLength(0)(1)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.Getarray.GetLength(0)(0); i++)
//     {
//         for (int j = 0; j < inputArray.Getarray.GetLength(0)(1); j++)
//         {
//             Console.Write(inputArray[i, j] + "\t");
//             // 1    2    3    4
//         }
//         Console.WriteLine();
//     }
// }
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// void ChangeRows(int[,] matrix)
// {
//     int indexLastRow = matrix.Getarray.GetLength(0)(0) - 1;
//     for (int i = 0; i < matrix.Getarray.GetLength(0)(1); i++)
//     {
//         int temp = matrix[0, i];
//         matrix[0, i] = matrix[indexLastRow, i];
//         matrix[indexLastRow, i] = temp;
//     }
// }
// ChangeRows(array);
// Console.WriteLine("Результат: ");
// PrintArray(array);


// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] CreateMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(11);
//         }
//     }
//     return array;
// }

// int[,] PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// void ConterMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[j, i] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] matrix = new int[4, 4];
// CreateMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// ConterMatrix(matrix);


// 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

// int rows2 = 5;
// int columns2 = 5;
// int[,] matrix = new int[rows2,columns2];
// int min = int.MaxValue;
// int indexRows = 0;
// int indexColumns = 0;
// for (int i = 0; i < rows2; i++)
// {
//     for (int j = 0; j < columns2; j++)
//     {
//         matrix[i,j] = new Random().Next(11);
//         Console.Write(matrix[i,j] + "\t");
//         if (min>matrix[i,j])
//         {
//             min = matrix[i,j];
//             indexRows = i;
//             indexColumns = j;
//         }
//     }
//     Console.WriteLine();
// }
// int[,] DeleteRowsColumns(int [,]array)
// {
//     for (int i = 0; i < array.Getarray.GetLength(0)(0); i++)
//     if(indexRows!=i)
//     {
//         for (int j = 0; j < array.Getarray.GetLength(0)(1); j++)
//         if (indexColumns !=j)
//         {
//             Console.Write(matrix[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }
// DeleteRowsColumns(matrix);




//=========Домашнее задание

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
    }
    return array;
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] forRegulate = new int[3, 4];
int[,] RegulateMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int buble = 0;
        while (buble < array.GetLength(1))
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] > array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
            buble++;
        }
    }
    return array;
}
CreateMatrix(forRegulate);
PrintMatrix(forRegulate);
Console.WriteLine();
RegulateMatrix(forRegulate);
PrintMatrix(forRegulate);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] arrayForMinSumm = new int[5, 4];
void FindMinSumm(int[,] array)
{
    int minRows = 0;
    int min = int.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i, j];
        }
        if (summ < min)
        {
            min = summ;
            minRows = i + 1;
        }
    }
    Console.Write($"В {minRows} строке - наименьшая сумма элементов.");
}
CreateMatrix(arrayForMinSumm);
PrintMatrix(arrayForMinSumm);
FindMinSumm(arrayForMinSumm);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
int[,] first = new int[5, 5];
int[,] second = new int[5, 5];
int[,] TwoArraysProduct(int[,] firstArray, int[,] secondArray)
{
    int[,] product = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            product[i, j] = firstArray[i, j] * secondArray[i, j];
        }
    }
    return product;
}

CreateMatrix(first);
PrintMatrix(first);
Console.WriteLine();
CreateMatrix(second);
PrintMatrix(second);
Console.WriteLine();
PrintMatrix(TwoArraysProduct(first, second));


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] threeDimensionalArray = new int[2, 2, 2];
int[,,] DoubleTruble(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);

                Console.Write($"{array[i, j, k]}({i},{j},{k})" + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    return array;
}
DoubleTruble(threeDimensionalArray);

// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] helix = new int[5, 5];
int columns = 0;
int rows = 0;
int minColumns = 0;
int minRows = 1;
int maxColumns = helix.GetLength(1)-1;
int maxRows = helix.GetLength(0)- 1;
int result = 1;
for (int k = 0; k < helix.Length -1 ;)
{
    while (columns < maxColumns)
    {
        helix[rows, columns] = result++;
        k++;
        columns++;
    }
    while (rows < maxRows)
    {
        helix[rows, columns] = result++;
        k++;
        rows++;
    }
    while (columns > minColumns)
    {
        helix[rows, columns] = result++;
        k++;
        columns--;
    }
    while (rows > minRows)
    {
        helix[rows, columns] = result++;
        k++;
        rows--;
    }
    maxColumns--;
    maxRows--;
    minColumns++;
    minRows++;
}
helix[rows, columns] = result;
PrintMatrix(helix);
