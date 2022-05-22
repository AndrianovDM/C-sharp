/* Задача 54 */
/*
Задайте двумерный массив. Напишите программу, 
которая упорядочит по возрастанию элементы каждой строки двумерного массива.
*/

int[,] CreateArray(int n , int m)
{
    int [,] array = new int [n,m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i,j] = new Random ().Next(1,10);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i =0; i< matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i , j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] OrderedArray(int[,] matrix)
{
    for (int i = 0; i< matrix.GetLength(0); i++)
    {   
        int temp = 0 ;
        for (int j = 0; j< matrix.GetLength(1) ; j++)
        {   
            for (int k = matrix.GetLength(1) - 1; k >= (j + 1); k--)
            {
                if(matrix[i, k] > matrix[i, k - 1])
                {
                    temp = matrix[i,k];
                    matrix[i, k]=matrix[i,k-1];
                    matrix[i, k-1]=temp;
                }
            }

        }
    }
    return matrix;
}

Console.Write("Input matrix width: ");
int width = Convert.ToInt32(Console.ReadLine());
Console.Write("Input matrix hight: ");
int hight = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
int[,] arr = CreateArray(width,hight);
Console.WriteLine(" ");
Console.WriteLine("Ordered matrix: ");
Console.WriteLine(" ");
PrintArray(OrderedArray(arr));