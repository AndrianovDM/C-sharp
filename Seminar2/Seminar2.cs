/*Задача №1*/
/*
void ShowNumber()
{
    int num = new Random().Next(10,99);
    int firtsNum = num / 10;
    int secondNum = num % 10;

    Console.Write(num + " -> ");

    if (firtsNum > secondNum)
        {
            Console.WriteLine(firtsNum);
        }
    else
        {
          Console.WriteLine(secondNum);  
        }
}
ShowNumber();
*/

/*Задача №1.1*/
/*
int ShowNumber()
{
    int num = new Random().Next(10,99);
    int firtsNum = num / 10;
    int secondNum = num % 10;

    Console.Write(num + " -> ");

    if (firtsNum > secondNum)
        {
            return firtsNum;
        }
    else
        {
          return secondNum;  
        }
}
int a = ShowNumber();
Console.WriteLine(a);
*/

/*Задача №1.2*/
/*
int ShowNumber(int n)
{
    int firtsNum = n / 10;
    int secondNum = n % 10;

    Console.Write(n + " -> ");

    if (firtsNum > secondNum)
        {
            return firtsNum;
        }
    else
        {
          return secondNum;  
        }
}
    
int num = new Random().Next(10,99);
int a = ShowNumber(num);
Console.WriteLine(a);
*/

/*Задача №2*/
/*
void ShowNumber()
{
    int num = new Random().Next(100,999);
    int firstNum = (num / 100) % 10;
    int secondNum = num % 10;
    string number = Convert.ToString(firstNum) + Convert.ToString(secondNum);
    Console.WriteLine(num + " -> " + Convert.ToInt32(number));
}
ShowNumber();
*/

/*Задача №3*/
/*
void IfMultiple()
{
    Console.Write("Input first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 % num2 == 0)
    {
        Console.Write(num1 + " is multipe of " + num2);
    }
    else
    {
       Console.Write(num1 + " is NOT multipe of " + num2); 
    }
}
IfMultiple();
*/

/*Задача №4*/
/*
void Multiple()
{
    Console.Write("Input integer number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 23 == 0 && num % 7 == 0)
    {
        Console.Write(num + " is multipe of " + "23 and 7 " );
    }
    else
    {
       Console.Write(num + " is NOT multipe of " + "23 and 7 " );
    }
}
Multiple();
*/

/*Задача №5*/
/*
void Square(int num1, int num2)
{
    if (num1 == num2 * num2)
    {
        Console.Write(num1 + " is square of " + num2);
    }
    else
    {
       Console.Write(num1 + " is NOT square of " + num2); 
    }
}

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Square(n1, n2); 
*/




