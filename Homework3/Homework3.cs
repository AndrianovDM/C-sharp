/*Задача #19

Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.*/

 void polindrom(int n)
 {  
    int numberLeftFirst = n / 10000;
    int numberRightFirst = n % 10;
    int numberLeftSecond = (n / 1000) % 10;
    int numberRightSecond = (n % 100) / 10;
    if (numberLeftFirst == numberRightFirst && numberLeftSecond == numberRightSecond)
    {
        Console.WriteLine("The number is a polyndrom");
    }
    else 
    {
        Console.WriteLine("The number is NOT a polyndrom");
    }
 }

Console.Write("Input five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (Convert.ToString(num).Length == 5)
{
    polindrom(num);
}
else
{   Console.WriteLine("ERROR");
    Console.Write("Input five-digit number");
}

