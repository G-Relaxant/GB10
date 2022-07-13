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
