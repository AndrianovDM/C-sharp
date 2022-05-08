/*Задача №1*/
/*
bool IsTriangleExist(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        return true;
    }
    return false;
}

if (IsTriangleExist(1,2,3))
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}
*/
/*Задача №2*/
/* Развернуть массив */

int [] CreateRandomArray(int size, int min, int max)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

}

int [] NewArray (int[] array)
{
    int newSize = array.Length;
    int[] newArray = new int[newSize];
    for (int i = 0, j = array.Length - 1; i< newSize; i++, j--)
    {
        newArray[i] = array[j];
    }
    return newArray;
}

int [] myArray = CreateRandomArray(10,0,10);
int [] newArr = NewArray(myArray);
ShowArray(myArray);
Console.WriteLine();
ShowArray(newArr);
