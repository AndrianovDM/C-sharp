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
/*
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
*/

/* Задача №6 */
/*
void FindWords(string alphabet, char[] word, int length = 0)
{
 if (length == word.Length)
 {
 Console.WriteLine($"{n++} {new String(word)}"); return;
 }
 for (int i = 0; i < alphabet.Length; i++)
 {
 word[length] = alphabet[i];
 FindWords(alphabet, word, length + 1);
 }
}
FindWords("аисв", new char[5]);
*/

/* Задача №7 */
/*
String path = "B:/KTZ";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
*/


/* Задача №8 */
/*
void CatalogInfo(string path, string indent = "")
{
 DirectoryInfo catalogs = new DirectoryInfo(path);
 foreach (var currentCatalog in catalogs.GetDirectories())
 {
 Console.WriteLine($"{indent}{currentCatalog.Name}");
 CatalogInfo(currentCatalog.FullName, indent + " ");
 }
 foreach (var item in catalogs.GetFiles())
 {
 Console.WriteLine($"{indent}{item.Name}");
 }
}
string path = @"B:/KTZ";
CatalogInfo(path);
*/

/* Задача №9 */
/*
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
 if (count > 1) Towers(with, some, on, count - 1);
 Console.WriteLine($"{with} >> {on}");
 if (count > 1) Towers(some, on, with, count - 1);
}

Towers();
*/

/* Задача №10 */

string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// 0 1 2 3 4 5 6 7 8 9 10 11
void InOrderTraversal(int pos = 1)
{
 if (pos < tree.Length)
 {
 int left = 2 * pos;
 int right = 2 * pos + 1;
 if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
 Console.WriteLine(tree[pos]);
 if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
 }
}

InOrderTraversal(2);


