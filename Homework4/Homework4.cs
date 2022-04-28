/* 
Задача №34
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
*/
/*
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

void FindNumberOfEven(int [] array)
{
    int even = 0;
    for (int i = 0; i <array.Length; i++)
    {
        if (array[i]%2 == 0)
        {   
            even ++;
        }
    }
    Console.WriteLine("Number of even elements -> " + even);
}

int[] myArray = CreateRandomArray(4, 100, 1000);
ShowArray(myArray);
FindNumberOfEven(myArray);
*/

/*
Задача №36 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
*/
/*
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
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SumUnevenPosition(int [] array)
{   
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    Console.WriteLine("Sum numbers in uneven positions -> " + sum);
}

int[] myArray = CreateRandomArray(10, 1, 100);
ShowArray(myArray);
SumUnevenPosition(myArray);
*/

/*
Задача №38
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
*/
/*
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
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void DifferenceMaxMin(int [] array)
{
    int i = 0;
    int maxElement = i;
    int minElement  = i;
    for (i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minElement])
            {
                minElement = j;
            }
        }

        for (int k = i + 1; k < array.Length; k++)
        {
            if (array[k] > array[maxElement])
            {
                maxElement = k;
            }
        }
    }
    Console.WriteLine("Max number: " + array[maxElement]);
    Console.WriteLine("Max number: " + array[minElement]);
    Console.WriteLine("Difference max min numbers-> " + (array[maxElement] -array[minElement]));
}

int[] myArray = CreateRandomArray(4, 1, 100);
ShowArray(myArray);
DifferenceMaxMin(myArray);
*/



