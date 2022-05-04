/*Задача №1*/

bool IsTriangleExist(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        return true;
    }
    return false;
}

if (IsTriangleExist(1,2,3))
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}

