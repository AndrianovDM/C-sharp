/* 
Задача №34
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
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