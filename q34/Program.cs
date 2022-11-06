//Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int sizeArray = GetPositiveInt("Введите длину массива");
int min = 100;
int max = 999;
int[] arr = CreateRandomArray(sizeArray, min, max);

PrintArray(arr);
PrintCountOddDigitIntArray(arr);

int[] CreateRandomArray(int sizeArray, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int GetPositiveInt(string massage)
{
    Console.WriteLine(massage);
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) ^ n < 0)
    {
        Console.Write("Ошибка\n" + massage);
    }
    return n;
}
void PrintArray(int[] inputArray)
{
    Console.WriteLine("[" + string.Join(",", inputArray) + "]");
}
void PrintCountOddDigitIntArray(int[] inputArray)
{
    int result = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] % 2 == 0) result++;
    }

    Console.WriteLine(result);
}



