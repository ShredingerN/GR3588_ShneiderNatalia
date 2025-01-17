﻿// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int row = ReadData("Введите количество строк ");                                 // Пользователь вводит количество строк
int column = ReadData("Введите количество столбцов ");                           // Пользователь вводит количество столбцов
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColor(arr2D);
Console.WriteLine();
(int x, int y) minElem = SearchMinElement(arr2D);
Console.WriteLine($"{minElem}");
int[,] covArr2D = Convert2DArray(arr2D, minElem.x, minElem.y);
Print2DArrayColor(covArr2D);


int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[matrix[i, j] % 15];
            Console.Write(matrix[i, j] + "   ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
// void Print2DArrayColor(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

(int x, int y) SearchMinElement(int[,] arr)
{
    int row = 0; int col = 0;
    int min = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                row = i;
                col = j;
            }
        }
    }
    return (row, col);
}

int[,] Convert2DArray(int[,] arr, int x, int y)
{
    int[,] outArray = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int k = 0; int m = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i != x && j != y)
            {
                outArray[k, m] = arr[i, j];
            }
            if (j != y) m++;
        }
        if (i != y) k++;
    }
    return outArray;
}
