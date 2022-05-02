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










