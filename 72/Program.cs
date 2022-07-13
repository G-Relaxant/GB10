int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1};
int[] info = {2, 3, 3, 1};
int[] answer = new int[info.Length];
int dataBitNumber = 0;
int currentBitsCount = 0;
int currentSum = 0;
int bufer = 0;
double dataBitNumberValue = 0;
int currentStep = 0;

for(int i = 0; i < info.Length; i++)
{
    currentBitsCount = info[i];
    currentStep = currentBitsCount;
    for(int j = 0; j < currentBitsCount; j++)
    {
        currentStep--;
        dataBitNumberValue = Convert.ToDouble(data[dataBitNumber]);
        bufer = Convert.ToInt32(dataBitNumberValue * (Math.Pow(2, currentStep)));
        dataBitNumber++;
        currentSum = currentSum + bufer;
        bufer = 0;
    }
    answer[i] = currentSum;
    currentSum = 0;
}
Console.WriteLine();
Console.Write($"Decimal numbers answer array: ");
PrintOneDimArray(answer);
Console.WriteLine();

void PrintOneDimArray(int[] a)
{
    Console.Write("[");
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i]);
        if(i < a.Length - 1)
            Console.Write(", ");
        else
            Console.WriteLine("]");
    }
}