/* Задача 41 */
/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {   
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }
    return array;
}

void CounterPositivUmber(int [] array)
{   
    int count = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.Write("Number of positive numbers: " + count);
}

Console.Write("How many numbers do you want to enter: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(len);
CounterPositivUmber(myArray);
*/

/* Задача 42 */
/*
Напишите программу, 
которая будет преобразовывать десятичное число в двоичное.
*/
/*
int Counter(int number)
{   
    int i = 0;
    while (number >= 1)
    {   
        number = number / 2;
        i++; 
    }
    return i;
}

int[] Binary(int number, int size)
{
    int[] array = new int[size];
    int i = 0;
    while(number >= 1)
    {
        array[i] = number % 2;
        number = number / 2;
        i++;
    }
    return array;
}

int [] Revers (int[] array)
{
    int newSize = array.Length;
    int[] newArray = new int[newSize];
    for (int i = 0, j = array.Length - 1; i < newSize; i++, j--)
    {
        newArray[i] = array[j];
    }
    return newArray;
}

int ShowNumber(int[] array)
{
    string bin = string.Empty;
    for (int i = 0; i < array.Length; i++)
        bin = bin + Convert.ToString(array[i]);
    int numberBin = Convert.ToInt32(bin);
    return numberBin;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = Counter(num);
int[] arr = Binary(num, count);
int[] newArr = Revers(arr);
int binaryNumber = ShowNumber(newArr);
Console.WriteLine(binaryNumber);
*/

/*Задача 43*/
/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/

void IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 -b1) / (k1 -k2);
    double y =  k2 * x + b2;
    Console.Write("(" + x + "," + y + ")");
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionPoint(k1,b1,k2,b2);



