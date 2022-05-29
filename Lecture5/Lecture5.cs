/* Задача №1 */
/*
// без применнения рекурсии
string NumbersFor(int a, int b)
{
 string result = String.Empty;
 for (int i = a; i >= b; i--)
 {
 result += $"{i} ";
 }
 return result;
}
Console.WriteLine(NumbersRec(1, 10));

// с помощью рекурсии
string NumbersRec(int a, int b)
{
 if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
 else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10)); 
 
*/

/* Задача №2 */
// без применнения рекурсии
int SumFor(int n)
{
 int result = 0;
 for (int i = 1; i <= n; i++) result += i;
 return result;
}
Console.WriteLine(SumRec(10)); 

// с помощью рекурсии
int SumRec(int n)
{
 if (n == 0) return 0;
 else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(10)); 




