//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
//int[] arr = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);


int[] inputArray = GetArrayFromConsole("Введите целые числа разделяя запятой : ");
int count = CountPositiveDigit(inputArray);

PrintArray(inputArray);

Console.WriteLine($"Кол-во элементов > 0: {count}");
 
int CountPositiveDigit(int[] inArray)
{
    int count = 0;
    foreach(int i in inArray)
    {
        if(i>0)count++;
    }
    return count;
}

int[] GetArrayFromConsole(string msg)
{
    Console.Write(msg);
    string[] inArray = Console.ReadLine()!.Split(",");
    int[] newArray = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        int.TryParse(inArray[i], out int value);
        newArray[i] = value;
    }
    return newArray;
}

void PrintArray(int[] inArray)
{
    Console.WriteLine($"[{String.Join(",",inArray)}]");
}