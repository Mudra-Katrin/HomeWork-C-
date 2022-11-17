//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.

int arrayLength = GetPositiveDigitFromConsole("Введите длинну массива: ");
int minValue = GetIntInput("Введите минимальное значение массива: ");
int maxValue = GetIntInput("Введите максимальное значение массива: ");

double[] array = MakeRandomDoubleArray(arrayLength, minValue, maxValue);

PrintDoubleArray(array);

Console.WriteLine($"Разница между макс и мин {Math.Round(array.Max() - array.Min(), 2)}");


void PrintDoubleArray(double[] inputArray)
{
    Console.WriteLine("[ " + string.Join("; ", inputArray) + " ]");
}

double[] MakeRandomDoubleArray(int arrayLength, int minValue, int maxValue)
{
    double[] madeArray = new double[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        double tmp =new Random().Next(minValue, maxValue+1) + new Random().NextDouble();
      
        madeArray[i] = Math.Round(tmp, 2);
    }
    //array[i] = rand.Next(-100, 100) + rand.NextDouble();
    return madeArray;
}

int GetPositiveDigitFromConsole(string text)
{
    Console.Write(text);
    int num;
    while (!int.TryParse(Console.ReadLine(), out num) ^ num < 0)
    {
        Console.Write("Ошибка\n" + text);
    }
    return num;
}

int GetIntInput(string text)
{
    Console.Write(text);
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.Write("Ошибка\n" + text);
    }
    return num;
}


