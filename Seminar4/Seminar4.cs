﻿/*Задача №1*/

int NaturalSum(int a)
{
    int sum = 0;
    if (a < 0)
    {
        return 0;
    }
    else
    {
        for (int i = 1; i <= a; i++)
        {
           sum += i;

        }
    return sum;
    }
}

Console.WriteLine("Input number:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum elementis: " + NaturalSum(num));