/* Задача №1 */
/* Задайте массив строк. 
Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву. */
/*
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

int NumberOfVowelLetters(string[] arr, string[] vowels)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
            {
                if (arr[i][0] == vowels[j][0])
                {
                    count++;
                }
            }
        }
    return count;
    }

string[] array = { "qwe", "wer", "ert", "rty", "tyu"};
string[] arrayOfVowels = {"A","a", "E", "e", "I", "i", "U", "u", "Y", "y", "O", "o"};

PrintArray(array);
Console.WriteLine("-> " + "number of words starting with vowels: " + NumberOfVowelLetters(array, arrayOfVowels));
*/

/* Задача №2 */
/*
Задайте массив строк. 
Напишите программу, которая генерирует новый массив,
 объединяя элементы исходного массива попарно.
 */
/*
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

string[] SumWords(string[] words)
{
    string[] newWords = new string[words.Length / 2];
    for(int i = 0, j = 0; i < words.Length; i = i + 2, j++)
            newWords[j] = words[i] + words[i + 1];
            
    return newWords;
}

string[] words ={ "qwe", "wer", "ert", "rty", "tyu", "yui"};

PrintArray(words);
Console.WriteLine();
Console.WriteLine("Union of elements: ");
PrintArray(SumWords(words));
*/



