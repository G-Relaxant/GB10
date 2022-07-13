// Мой вариант
/*
Console.Write("Input number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write($"{numberA}, {numberB}");
numberA = numberA + numberB;
if(numberN == 3)
{
    Console.Write($", {numberA}");
}
else
{
    if(numberN > 3)
    {
        if(numberN % 2 == 0)
        {
            for(int i = 1; i < numberN / 2; i++)
            {
                Console.Write($", {numberA}");
                numberB = numberA + numberB;
                Console.Write($", {numberB}");
                numberA = numberA + numberB;
            }
        }
        else
        {
            for(int i = 1; i < numberN / 2; i++)
            {
                Console.Write($", {numberA}");
                numberB = numberA + numberB;
                Console.Write($", {numberB}");
                numberA = numberA + numberB;
            }
            Console.Write($", {numberA}");
        }
    }
    else
    if(numberN < 2)
    {
        Console.WriteLine();
        Console.WriteLine($"Number N should having value bigger than 1");
    }
}
*/




// Вариант от преподавателя
/*
Console.Write("Input number A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Input number B: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Input number N: ");
int numberN = int.Parse(Console.ReadLine());

for(int i = 1; i <= numberN; i++)
{
    Console.Write(FibonacciSimilarSequence(numberA, numberB, i) + " ");
}

int FibonacciSimilarSequence(int a, int b, int c)
{
    if(c == 1)
        return a;
    if(c == 2)
        return b; 
    else
    {
        int sum = FibonacciSimilarSequence(a, b, c - 1) + FibonacciSimilarSequence(a, b, c - 2);
        return sum;
    }
}
*/



// Вариант из семинара

Console.Write("Input number A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Input number B: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Input number N: ");
int numberN = int.Parse(Console.ReadLine());

Console.WriteLine(FibonacciSimilarSequence(numberA, numberB, numberN));

string FibonacciSimilarSequence(int a, int b, int c)
{
    if(c == 0)
    {
        return string.Empty;
    }
    else
    {
        return a + " " + FibonacciSimilarSequence(b, a + b, --c);
    }
}