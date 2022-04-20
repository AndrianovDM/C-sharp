/*Задача №1 */

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