﻿// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.(факториал)
//подключаем большие числа, чтобы сработал big integer
using System.Numerics;

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

BigInteger CalcFactor(int num)
{    
    BigInteger count = 1;
    for(int i=1;i<=num;i++)
    {
       count *= i;
    }
    return count;
}

int number = ReadData("Введите число А:");

BigInteger length1 = CalcFactor(number);

PrintData("Факториал равно^ " + length1);

