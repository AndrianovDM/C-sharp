/*Задача №1*/

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

