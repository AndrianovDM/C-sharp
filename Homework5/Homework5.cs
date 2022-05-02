/*
Задача №1
Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
*/
/*
int degreeOfNumber(int A, int B)
{
    int num = A;
    if (B > 0)
    {   
        for (int i = 1; i < B; i++)
        {
            num = num * A;   
        }
    }
    else
    {
        Console.Write(B +" Not a natural number ");  
    }
    return(num);
}

Console.Write("Input number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input degree: ");
int numB = Convert.ToInt32(Console.ReadLine());
int number = degreeOfNumber(numA,numB);
Console.Write(number);
*/

/* Задача №2 */
/*
Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.
*/

int getNumber(int num)
{
    int number = num%10;
    return number;
}

int sumNumber(int num)
{   
    int count = 0;
    int sum = 0;
    while (num > 0)
    {
        sum += getNumber(num);
        num = num / 10;
        count++;
    }
    return sum;
}
Console.WriteLine("Input number:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum number: " + sumNumber(num));