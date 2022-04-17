/*Задача 1: 
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/

Console.Write("Input integer first number: ");
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
}