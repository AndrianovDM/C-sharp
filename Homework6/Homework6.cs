/* Задача 41 */
/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

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

