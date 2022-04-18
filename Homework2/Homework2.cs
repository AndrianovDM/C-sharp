/*
Задача 10:
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
*/

void ShowNumber(int num)
{
    int number = (num / 10) % 10;
    Console.Write(num + " -> " + number);
}

Console.Write("Input integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumber(n);


