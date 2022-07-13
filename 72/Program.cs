// Мой вариант
/*
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
*/




// Вариант от преподавателя

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1};
int[] info = {2, 3, 3, 1};
int[] answerDecimalNumbers = GetNumbersFromDataInfo(data, info);

Console.Write("data = ");
PrintArray(data);

Console.Write("info = ");
PrintArray(info);

Console.Write("result = ");
PrintArray(answerDecimalNumbers);

int GetDecimal(int[] bits, int minIdx, int maxIdx)
{
    int number = 0;
    for(int i = minIdx; i < maxIdx + 1; i++)
    {
        number += bits[i] * (int)Math.Pow(2, maxIdx - i);
    }
    return number;
}

int[] GetNumbersFromDataInfo(int[] bits, int[] sizes)
{
    int[] numbers = new int[sizes.Length];
    int startIdx = 0;
    int endIdx = -1;
    for(int i = 0; i < numbers.Length; i++)
    {
        startIdx = endIdx + 1;
        endIdx = endIdx + sizes[i];
        int number = GetDecimal(bits, startIdx, endIdx);
        numbers[i] = number;
    }
    return numbers;
}

void PrintArray(int[] a)
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
