/*Задача №1*/
/*
int NaturalSum(int a)
{
    int sum = 0;
    if (a < 0)
    {
        return 0;
    }
    else
    {
        for (int i = 1; i <= a; i++)
        {
           sum += i;

        }
    return sum;
    }
}

Console.WriteLine("Input number:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum elementis: " + NaturalSum(num));
*/

/*Задача №2*/
/*
int Faktorial(int a)
{   
    int faktor = 1;
    if (a < 1) return 0;
    else
    { 
        for (int i = 1; i <= a; i++)
        {
            faktor =faktor * i;
        }
    return(faktor);
    }
}

Console.WriteLine("Input number:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Faktorial: " + Faktorial(num));
*/

/*Задача №3*/
/*
int GetDigitAmount(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num/ 10;
        count++;
    }
    return count;
}
Console.WriteLine("Input number:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Amount of digits is: " + GetDigitAmount(num));
*/

/*Задача №4*/
/*
int[] PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,2);
        Console.Write(arr[i]+" ");
    }
    return arr;
}
int [] array = new int[9];
PrintArray(array);
*/

/*Задача №5*/
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

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Input " + i +" element");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

void FindSumOfElements(int[] array)

{
    int plusSum = 0;
    int minusSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            plusSum += array[i];
        }
        else
        {
            minusSum += array[i];
        }
    }
    Console.WriteLine("Sum of positive elements is " + plusSum);
    Console.WriteLine("Sum of negative elements is " + minusSum);
}


int[] myArray = CreateRandomArray(6, -5, 5);
ShowArray(myArray);
FindSumOfElements(myArray);
*/
