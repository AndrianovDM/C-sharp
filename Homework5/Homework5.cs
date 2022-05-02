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
/*
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
*/

/* Задача №3 */
/*
Напишите программу, 
которая задаёт массив из 8 элементов и выводит их на экран.
*/

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random ().Next(min, max);
    }

    return array;
}

void ShowArray(int [] array)
{
    for (int i =0; i< array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void printArray(int[] array)
{
    Console.Write("[");
    int len =array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write("{0}, ", array[i]);
    }
    Console.Write("]");
}

int[] myArray = CreateRandomArray(8, 0, 99);
ShowArray(myArray);
Console.WriteLine();
printArray(myArray);