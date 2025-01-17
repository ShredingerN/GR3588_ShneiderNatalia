﻿// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int countRow = ReadData("Введите количество строк треугольника Паскаля: ");
PrintPascalTriangle(countRow);

int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

float Factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

void PrintPascalTriangle(int nRow)
{
    for (int i = 0; i < nRow; i++)
    {
        // создаём после каждой строки n-i отступов от левой стороны консоли, 
        // чем ниже строка, тем меньше отступ
        for (int j = 0; j <= (nRow - i); j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            // создаём пробелы между элементами треугольника
            Console.Write(" ");
            //формула вычисления элементов треугольника
            Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j)));
        }
        Console.WriteLine();
    }
}

