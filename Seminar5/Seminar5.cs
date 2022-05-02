/*Задача №1*/
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

int [] ChangeNums(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= (-1);  
    }
    return array;
}

int[] myArray = CreateRandomArray(4, 1, 10);
ShowArray(myArray);
Console.WriteLine();
int[] array = ChangeNums(myArray);
ShowArray(myArray);
*/

/*Задача №2*/
/*
int[] massiv = {3, 54, 431, 43, 21};

string CheckNuminArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) 
        {
            return "Yes";
        }
    }
    return "No";
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CheckNuminArray(massiv, num));
*/

/*Задача №3*/
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random ().Next(min, max+1);
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

int FindNumbs(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

int [] myArray = CreateRandomArray(15,-10, 1000);
ShowArray(myArray);
Console.WriteLine();
int numb = FindNumbs(myArray);
Console.WriteLine(numb);
*/

/*Задача №4*/
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

int[] NewMagicArray(int[] array)
{
    int newSize = array.Length/2;
    int[] newArray = new int[newSize];

    for (int i = 0, j= array.Length -1; i < newSize; i++, j--)
    {
        newArray[i] = array[i] * array[j];
    }
    return newArray;
}

int[] arr = CreateRandomArray(6, 1, 9);
ShowArray(arr);
Console.WriteLine();
int[] newArr = NewMagicArray(arr);
ShowArray(newArr);
*/












