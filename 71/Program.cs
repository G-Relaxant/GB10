// Мой вариант
/*
Console.Write("Input number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
string alphabet = "aisv";
if(numberN > 0 && numberN < 5)
{
    if(numberN == 1)
    {
        Console.Write($"{alphabet[0]}");
        for(int i = 1; i < 4; i++)
        {
            Console.Write($", ");
            Console.Write($"{alphabet[i]}");
        }
    }
    if(numberN == 2)
    {
        Console.Write($"{alphabet[0]}{alphabet[0]}");
        for(int i = 0; i < 4; i++)
        {
            for(int j = 1; j < 4; j++)
            {
                Console.Write($", ");
                Console.Write($"{alphabet[i]}{alphabet[j]}");
            }
        }
    }
    if(numberN == 3)
    {
        Console.Write($"{alphabet[0]}{alphabet[0]}{alphabet[0]}");
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                for(int k = 1; k < 4; k++)
                {
                    Console.Write($", ");
                    Console.Write($"{alphabet[i]}{alphabet[j]}{alphabet[k]}");
                }
            }
        }
    }
    if(numberN == 4)
    {
        Console.Write($"{alphabet[0]}{alphabet[0]}{alphabet[0]}{alphabet[0]}");
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                for(int k = 0; k < 4; k++)
                {
                    for(int l = 1; l < 4; l++)
                    {
                        Console.Write($", ");
                        Console.Write($"{alphabet[i]}{alphabet[j]}{alphabet[k]}{alphabet[l]}");
                    }
                }
            }
        }
    }
}
else
{
    Console.Write($"Number N should having value from 1 to 4");
}
*/




// Вариант от преподавателя, работает с любой длиной слова

string charsWord = "аисв";
Console.Write("Input count of chars in words: ");
int countCharsInWords = int.Parse(Console.ReadLine());
PrintAllWords(charsWord, countCharsInWords, "");

void PrintAllWords(string alphabet, int length, string prefix)
{
    if(length == 0)
    {
        Console.Write(prefix + " ");
    }
    else
    {
        for(int i = 0; i < alphabet.Length; i++)
        {
            PrintAllWords(alphabet, length - 1, prefix + alphabet[i]);  // Максимальное число ступеней рекурсии = введённому числу, то есть количеству разрядов(символов) 
                                                                        // в слове, которое выводится в консоль. Рекурсии перебирают разряды слов, а цикл переби-
                                                                        // рает разряды алфавита(charsWord)
        }
    }
}