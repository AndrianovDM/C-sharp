/* Задача №66 */
/*
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
*/
/*
int SumNumber(int m, int n)
{
    if (m <= n)
    {
        return m + SumNumber(m + 1, n);
    }
    else
        return 0;

}
Console.WriteLine("Input number start: ");
int numStart = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number finish: ");
int numFinish = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum of numbers: ");
Console.Write(SumNumber(numStart, numFinish));
*/

/* Задача №67 */ 
/* Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. */

int NumberSum(int m)
{
    if (m == 0)
    {   
        return 0;
    }
    else
        return m % 10 + NumberSum(m/10);
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum of numbers: ");
Console.Write(NumberSum(num));