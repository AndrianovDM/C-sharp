/* 
Задача №47
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/
/*
double[,] CreateArray(int m, int n)
{   
    double[,] array = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble(),2);
        }
    }
    return array;
}

void ShowArray(double [,] matrix)
{
    for (int i =0; i< matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input size of matrix m = ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input size of matrix n = ");
int size2 = Convert.ToInt32(Console.ReadLine());

double[,] matrix = CreateArray(size1,size2);
ShowArray(matrix);
*/

/*
Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/
/*
int[,] matrix = new int[4, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0,10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Input find vertical element m > 0:");
int m = Convert.ToInt32(Console.ReadLine()) -1;
Console.WriteLine("Input find horizontal element n > 0:");
int n = Convert.ToInt32(Console.ReadLine()) -1;

if (matrix.GetLength(0) >= m && matrix.GetLength(1) >= n)
    {
        Console.WriteLine("Element found: " + matrix[m, n]);
    }
else 
{
    Console.WriteLine("Element NOT found");
}
*/

/*
Задача 52
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
*/
/*
int[,] matrix = new int[4, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0,10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{   
    double arithmeticMean = 0;
    double[,] newMatrix = new double[matrix.GetLength(0),matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        newMatrix[i, j] = matrix[j, i];
        arithmeticMean += newMatrix[i, j];
    }
    Console.Write(arithmeticMean/4 + ", ");
}
*/








