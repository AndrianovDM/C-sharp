/*Задача №1*/

/*Console.Write("Введите ваше имя ");
string username = Console.ReadLine();
Console.Write("Привет, ");
Console.Write(username); */

/*Задача №2*/

/*int numberA = 31;
int numberB = 5;
int result = numberA + numberB;
Console.WriteLine(result);*/

/*Задача №3*/

/*double numberA = 31;
double numberB = 5;
Console.WriteLine(numberA / numberB);*/

/*Задача №4*/

/*int numberA = new Random().Next(1,10); //создает рандомное число от 1 2 3 4...9
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10); 
Console.WriteLine(numberB);
int.result = numberA + numberB;
Console.WriteLine(result);*/

/*Задача №5*/

/*Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}*/

/*Задача №6*/
/*

int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.Write(max);

*/


/*Задача №6*/

Console.Clear();  //отчистка консоли

// Console.SetCursorPosition(10, 4); // позиция символа в консоли
// Console.WriteLine("+");

int xa = 30, ya = 1,
    xb = 1, yb = 20,
    xc = 60, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = yb;
int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0,3);  // [0;3) 0 1 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}











