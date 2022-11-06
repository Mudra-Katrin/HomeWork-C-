// See https://aka.ms/new-console-template for more information
int arrayLength = GetPositiveIntInput("Введите длинну массива: ");
int minValue;
int maxValue;
//! - что ошибку не выдавало или другого назначения?
while (!((maxValue = GetIntInput("Введите максимальное число для массива: ")) >= (minValue = GetIntInput("Введите минимальное число для массива: "))))
{//я читаю:пока мах >= мин ="максимальное должно быть больше или равно минимальному"И 
//не понимаю почему.это ведь выполняет словие и предупреждение не должно выводиться.
    Console.WriteLine("максимальное должно быть больше или равно минимальному");
}

int[] array = MakeRandomArray(arrayLength, minValue, maxValue);

Console.WriteLine($"{ArrayToString(array)}");

int[] MakeRandomArray(int arrayLength, int min, int max)
{
    int[] madeArray = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        madeArray[i] = new Random().Next(min, max + 1);
    }

    return madeArray;
}

string ArrayToString(int[] array)
{
    string text = "[" + String.Join(", ", array) + "]";

    return text;
}

int GetPositiveIntInput(string text)
{
    Console.Write(text);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) ^ value <= 0)
    {//я так понимаю: если значение не число или число отрицательно, 
    //то выводит 40строку в""/!знак опять не понимаю его необходимость
        Console.Write("нужно положительное число: ");
    }
    return value;
}

int GetIntInput(string text)
{
    Console.Write(text);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value))
    {//я понимаю: если пользователь ввел не число. но в какой запрос или любой. 
    //в 38 строке out value тоже было
        Console.Write("необходимо число: ");
    }
    return value;
}