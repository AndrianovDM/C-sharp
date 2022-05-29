/* Задача № 1 */
/*
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
*/

/* Задача № 2 */

string[] names = {"Pavel", "Oleg", "Anna", "Nikita", "Max"};

string[] SortArray(string[] words)
{   
    string temp = string.Empty;
    for (int i = 0; i < words.Length - 1; i++)
    {
        for (int j = 0; j < words.Length - 1 -i; j++)
        {
            if (words[j].Length > words[j + 1].Length)
            {
                temp = words[j];
                words[j] = words[j + 1];
                words[j + 1] = temp;
            }
            else if (words[j].Length == words[j + 1].Length)
            {
                for (int k = 0; k < words[j].Length; k++)
                {
                    if (words[j][k] > words[j + 1][k])
                    {
                        temp = words[j];
                        words [j] = words[j + 1];
                        words [j + 1] = temp;
                        break;
                    }
                    else if (words[j][k] < words[j + 1][k]) break;
                }
            }
        }
    }
    return words;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

PrintArray(SortArray(names));