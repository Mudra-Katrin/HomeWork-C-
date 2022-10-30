// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.


int arrayLength =  GetIntInput("Введите длинну массива");
int minValue =  GetIntInput("Введите минимальное значение массива");
int maxValue =  GetIntInput("Введите максимальное значение массива");

int[] array = MakeRandomArray(arrayLength, minValue, maxValue);

int[] MakeRandomArray(int arrayLength, int minValue, int maxValue)
{
    int[] madeArray = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        madeArray[i] = new Random().Next(minValue, maxValue+1);
    }

    return madeArray;
}

int GetIntInput(string text)
{
    Console.Write(text);

    int num = int.Parse(Console.ReadLine()!);
    
    return num;
}

    int input = MakeRandomArray(arrayLength, minValue, maxValue);
    int oddSum = 0;
    for (int i=1; i<arrayLength; i+2)
    {
        oddSum += input [i];
    }
//берем значение  1го индекса (т.к. он первый нечетный) , если оно меньше длины массива
//суммируем его  и далее переходим к значению индекса увеличивая его на 2
string inputString = string.Join(",", input);
Console.WriteLine("Array=" + inputString + "oddSum=" + oddSum);


