﻿/*
Задача 10:
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
*/
/*
void ShowNumber(int num)
{
    int number = (num / 10) % 10;
    Console.Write(num + " -> " + number);
}

Console.Write("Input integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumber(n);
*/

/*Задача 13:
Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
*/

void ThirdNumber(int num)
{   
    int number1 = num;
    int number2 = num / 100;
    int current = 1;
    if (number2 == 0)
    {
        Console.Write("NOT third number");
    }
    else
    {   
        int n = Convert.ToString(number1).Length;
        // перевел число в строковую переменную и определил с помощью метода "Length" кол-во символов
        while(current <= (n-3))
        {   
            num = (num / 10);
            current++;
        }
        int number3 = num % 10;
        Console.Write(number1 + " -> " + number3);
    }
}

Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
ThirdNumber(a);


