/* 
Задача №47
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/

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

