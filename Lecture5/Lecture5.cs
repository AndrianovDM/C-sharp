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
/*
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
*/
/* Задача №3 */
// без применнения рекурсии
/*
int FactorialFor(int n)
{
 int result = 1;
 for (int i = 1; i <= n; i++) result *= i;
 return result;
}
Console.WriteLine(FactorialRec(10));

// с помощью рекурсии
int FactorialRec(int n)
{
 if (n == 1) return 1;
 else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialFor(10)); 
*/

/* Задача №4 */
/*
// без применнения рекурсии
int PowerFor(int a, int n)
{ int result = 1;
 for (int i = 1; i <= n; i++) result *= a;
 return result;
}

Console.WriteLine(PowerFor(2, 10)); 

// с помощью рекурсии
int PowerRec(int a, int n)
{ return n == 0 ? 1 : PowerRec(a, n - 1) * a;
 else return PowerRec(a, n - 1) * a;
}

Console.WriteLine(PowerRec(2, 10)); 
*/


/* Задача №5 */

char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
 for (int j = 0; j < count; j++)
 {
 for (int k = 0; k < count; k++)
 {
 for (int l = 0; l < count; l++)
 {
 for (int m = 0; m < count; m++)
 {
 Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
 }
 }
 }
 }
}



