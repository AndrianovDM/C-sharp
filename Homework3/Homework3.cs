/*Задача #19

Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.*/
/*
 void polindrom(int n)
 {  
    int numberLeftFirst = n / 10000;
    int numberRightFirst = n % 10;
    int numberLeftSecond = (n / 1000) % 10;
    int numberRightSecond = (n % 100) / 10;
    if (numberLeftFirst == numberRightFirst && numberLeftSecond == numberRightSecond)
    {
        Console.WriteLine("The number is a polyndrom");
    }
    else 
    {
        Console.WriteLine("The number is NOT a polyndrom");
    }
 }

Console.Write("Input five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (Convert.ToString(num).Length == 5)
{
    polindrom(num);
}
else
{   Console.WriteLine("ERROR");
    Console.Write("Input five-digit number");
}
*/

/* Задача №21

Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
*/
/*
double distance( int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(((xA - xB) * (xA - xB)) + ((yA - yB) * (yA - yB)) + ((zA - zB) * (zA - zB)));
}

Console.Write("Input X coordinate of the point A: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate of the point A: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z coordinate of the point A: ");
int Az = Convert.ToInt32(Console.ReadLine());

Console.Write("Input X coordinate of the point B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate of the point B: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z coordinate of the point B: ");
int Bz = Convert.ToInt32(Console.ReadLine());

Console.Write("distance AB: " + distance(Ax, Ay, Az, Bx, By, Bz));
*/

/*Задача 23*/

/*Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.*/
/*
void cubeTable(int N)
{   
    int count = 1;
    Console.Write(N + " -> ");
    Console.Write(count * count * count);
    count++;
    while (count <= N)
    {   
        Console.Write(", " + count * count * count);
        count++;
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    cubeTable(num);
}
else
{
    Console.Write("Input positive number");
}
*/

