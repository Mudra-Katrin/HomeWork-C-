
string[] manualInputArray = GetArrayFromConsole("Введите массив данных разделяя , : ");
Console.WriteLine($"{ArrayToString(manualInputArray)}");

//string[] resultManualInputArray = 
FindStringBySizeInArray(manualInputArray);
//ShowResult(manualInputArray, resultManualInputArray);


string[] GetArrayFromConsole(string message = "")
{
    Console.Write(message);
    return Console.ReadLine()!.Split(",");
}

// void ShowResult(string[] test, string[] result)
// {
//     Console.ForegroundColor = ConsoleColor.Green;
//     Console.WriteLine();
//     ShowArray(test);
//     Console.ForegroundColor = ConsoleColor.Red;
//     Console.Write("->");
//     Console.ForegroundColor = ConsoleColor.Yellow;
//     ShowArray(result);
//     Console.ForegroundColor = ConsoleColor.White;
//     Console.WriteLine();
// }
void FindStringBySizeInArray(string[] arr2)
{
    Console.WriteLine("Результат: ");
    string[] newarr = new string[arr2.Length];
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i].Length <= 3)
        {
            newarr[i] = arr2[i];     // ЧТО ДЕЛАЕТ ЭТА СТРОКА?
            Console.Write("{0}\t", newarr[i]);
        }
    }
}
// string[] FindStringBySizeInArray(string[] str, int length = 3) => str.Where(s => s.Length <= length).ToArray();
// //s => s.Length <= length-не поняла, что такое s и s.Length
// void ShowArray(string[] inputArray)
// {
//     if (inputArray.Length > 0 && inputArray[0].Length != 0)
//     {
//         Console.Write($"[\"{String.Join("\",\"", inputArray)}\"]");
//     }
//     else
//     {
//         Console.Write("[]");
//     }
//}
string ArrayToString(string[] array)
{
    
    string text = "[" + String.Join(", ", array) + "]";
    
    return text;
}