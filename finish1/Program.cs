
string[] manualInputArray = GetArrayFromConsole("Введите массив данных разделяя , : ");
Console.WriteLine($"{ArrayToString(manualInputArray)}");

FindStringBySizeInArray(manualInputArray);

string[] GetArrayFromConsole(string message = "")
{
    Console.Write(message);
    return Console.ReadLine()!.Split(",");
}

void FindStringBySizeInArray(string[] arr2)
{
    Console.WriteLine("Результат: ");
    string[] newarr = new string[arr2.Length];
 
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i].Length <= 3)
        {
            newarr[i] = arr2[i];
            
        }
       
    }
    Console.Write($"{ArrayToString(newarr)}");
    
}
string ArrayToString(string[] array)
{

    string text = $"[\"{String.Join("\",\"", array)}\"]";
    return text;
}