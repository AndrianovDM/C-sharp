/* Задача№1 */
/*
NaturalNums(5);

void NaturalNums(int n)
{
    if (n >= 1 )
    {
        Console.Write(n + " ");
        NaturalNums(n-1);
    }
}
*/

/* Задача№2 */

int TestRecurse(int n , int m)
{
    if (m >= 1)
    {
        m-= 1;
        return n * TestRecurse(n, m);
    }
    else
        return 1;
}

Console.Write(TestRecurse(2,4));