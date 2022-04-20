/*Задача №1 */
/*
int FindQvart(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;
    else
        return 0; 
}   

Console.Write("Input X coordinate ");
int xDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate ");
int yDot = Convert.ToInt32(Console.ReadLine());

int qvartNumb = FindQvart(xDot, yDot);

if (qvartNumb == 0)
{
    Console.Write(" Dot located on the axel ");
}
else
    Console.Write(" Number of quart is: " + qvartNumb);
*/

/*Задача №2 */
/*
void FindQvart(int q)
{
    if (q == 1)
        Console.Write(" location: x > 0 and y > 0");

    else if (q == 2)
        Console.Write(" location: x < 0 and y > 0");
        
    else if (q == 3)
        Console.Write(" location: x < 0 and y < 0");
    else if (q == 4)
        Console.Write(" location: x > 0 and y < 0");
    else
        Console.Write("Located on the axis");
}   

Console.Write("Input number of qvart from 0 to 4: ");
int qvartNumb = Convert.ToInt32(Console.ReadLine());

if (qvartNumb > 4 || qvartNumb < 0 )
{
    Console.Write("Inccorect number");
}
else
{
   FindQvart(qvartNumb); 
}
*/

/*Задача №3*/
/*
double distance( int xA, int yA, int xB, int yB)
{
    return Math.Sqrt(((xA - xB) * (xA - xB)) + ((yA - yB) * (yA - yB)));
}

Console.Write("Input X coordinate of the point A: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate of the point A: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Input X coordinate of the point B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate of the point B: ");
int By = Convert.ToInt32(Console.ReadLine());

Console.Write("distance AB: " + distance(Ax, Ay, Bx, By));
*/

/*Задача №4*/

void sqr(int N)
{   int count = 1;
    Console.Write(N + " -> ");
    Console.Write(count*count);
    count++;
    while (count <= N)
    {   
        Console.Write(", " + count*count);
        count++;
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    sqr(num);
}
else
{
    Console.Write("Input positive number");
}
