//  Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//(на входе N- длина массива, min и max- ограничения для значений элементов массива, которые лежат в [min, max])
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int arrayLength = GetIntInput("Введите длинну массива: ");
int minValue = GetIntInput("Введите минимальное число для массива: ");
int maxValue = GetIntInput("Введите максимальное число для массива: ");

int[] array = MakeRandomArray(arrayLength, minValue, maxValue);

Console.WriteLine($"{ArrayToString(array)}");

int[] MakeRandomArray(int arrayLength, int min, int max)
{
    int[] madeArray = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        madeArray[i] = new Random().Next(min, max+1);
    }

    return madeArray;
}

string ArrayToString(int[] array)
{
    
    string text = "[" + String.Join(", ", array) + "]";
    
    return text;
}

int GetIntInput(string text)
{
    Console.Write(text);

    int num = int.Parse(Console.ReadLine()!);
    
    return num;
}

