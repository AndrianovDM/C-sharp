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



