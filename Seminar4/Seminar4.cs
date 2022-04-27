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


