// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.


int arrayLength =  GetPositiveInput("Введите длинну массива :");
int minValue =  GetIntInput("Введите минимальное значение массива :");
int maxValue =  GetIntInput("Введите максимальное значение массива :");

int[] array = MakeRandomArray(arrayLength, minValue, maxValue);
PrintSummOddIndexArray(array);

void PrintSummOddIndexArray(int[]inputArray)
{
    int oddSum=0;
        for (int i = 1; i < inputArray.Length; i+=2)
    {
        oddSum += inputArray[i];
    }            
string inputString = string.Join(",", inputArray);
Console.WriteLine("\nArray[" + inputString + "]\noddSum=" + oddSum);  
}

int[]MakeRandomArray(int arrayLength, int minValue, int maxValue)
{
    int[]madeArray=new int [arrayLength];
    for(int i=0; i<arrayLength;i++)
    {
        madeArray[i]=new Random().Next(minValue, maxValue+1);
    }
    return madeArray;
}

int GetPositiveInput(string text)
{
    Console.Write(text);
    int num;
    while (! int.TryParse(Console.ReadLine(),out num) ^ num<0)
    {
Console.Write("Ошибка\n" + text);
    }
    return num;
}
int GetIntInput(string text)
{
    Console.Write(text);
    int num;
    while(!int.TryParse(Console.ReadLine(),out num))
    {
        Console.Write("Ошибка\n"+text);
    }
return num;
}
//берем значение  1го индекса (т.к. он первый нечетный) , если оно меньше длины массива
//суммируем его  и далее переходим к значению индекса увеличивая его на 2



