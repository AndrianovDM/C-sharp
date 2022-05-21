/* Задача №1 */
/*
int[,] CreateArray(int n , int m)
{
    int [,] array = new int [n,m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i,j] = new Random ().Next(-10,11);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] ChangeRowColor(int[,] matrix)
{
    int tmp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        tmp = matrix[0,i];
        matrix[0,i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1,i] = tmp;
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i =0; i< matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i , j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Input matrix width: ");
int width = Convert.ToInt32(Console.ReadLine());
Console.Write("Input matrix hight: ");
int hight = Convert.ToInt32(Console.ReadLine());

int[,] arr = CreateArray(width,hight);
Console.WriteLine(" ");
PrintArray(ChangeRowColor(arr));
*/

/* Задача №2 */
/*
int[,] CreateArray(int n , int m)
{
    int [,] array = new int [n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i,j] = new Random ().Next(-10,11);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] ChangeRowColor(int[,] matrix)
{
    int[,] result = new int [matrix.GetLength(0) ,matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i, j] = matrix [j, i];
        }
    }
    return result;
}

Console.Write("Input matrix width: ");
int width = Convert.ToInt32(Console.ReadLine());
Console.Write("Input matrix hight: ");
int hight = Convert.ToInt32(Console.ReadLine());
int [,] arr = CreateArray(hight, width);

if (hight == width)
{
    PrintArray(ChangeRowColor(arr));;
}
else
{
    Console.WriteLine(" Cannot change row to column. Matrix is not square");
}
*/

/* Задача №3 */

int[,] CreateArray(int n , int m)
{
    int [,] array = new int [n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i,j] = new Random ().Next(-10,11);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] ChangeRowColor(int[,] matrix)
{
    int tmp = 0;
    int k = matrix.GetLength(0) - 1;
    int l = matrix.GetLength(1) - 1;


    for (int i = 0; i <= k; i++)
    {
        for (int j = i + 1; j <= l ; j++)
        {
            tmp = matrix[i , j];
            matrix[i, j] = matrix[j , i];
            matrix[j, i] = tmp;
        }
    }
    return matrix;
}

Console.Write("Input matrix width: ");
int width = Convert.ToInt32(Console.ReadLine());
Console.Write("Input matrix hight: ");
int hight = Convert.ToInt32(Console.ReadLine());
int [,] arr = CreateArray(hight, width);

if (hight == width)
{
    PrintArray(ChangeRowColor(arr));;
}
else
{
    Console.WriteLine(" Cannot change row to column. Matrix is not square");
}