/* Задача № 1 */

int CountEven(string[] words)
{
    int count = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length % 2 == 0) count++;
    }
    return count;
}

string[] names = {"Pavel", "Anna", "Denis"};

Console.WriteLine(CountEven(names));