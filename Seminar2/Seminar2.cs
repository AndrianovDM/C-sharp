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