/*Задача 1: 
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/

/*Console.Write("Input integer first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write("max number = " + num1);
    Console.Write("min number = " + num2);
}
else if(num1 < num2)
{
    Console.Write("max number = " + num2);
    Console.Write("min number = " + num1);
}
else 
{
   Console.Write("the number " + num1 + " = " + num2);  
}*/


/*Задача 2: 
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/

/*Console.Write("Input integer first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2 && num1 >= num3) 
{
    Console.Write("max number = " + num1);    
}

else if (num2 >= num1 && num2 >= num3) 
{
    Console.Write("max number = " + num2);    
}
else if (num3 >= num1 && num3 >= num2) 
{
    Console.Write("max number = " + num3);    
}*/


/*Задача 3: 
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).*/

/*Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = num % 2;
if (a == 0)
{
    Console.Write(num + " - number is even");
}
else
{
    Console.Write(num + " - number is not even");    
}*/


/*Задача 4: 
Напишите программу, которая на вход принимает число (N), а 
на выходе показывает все чётные числа от 1 до N.*/

Console.Write("input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
int a;

while(current <= num)
{   a = current % 2;
    if (a == 0)
        {Console.Write(current + " ");
        }
    current++;
}
