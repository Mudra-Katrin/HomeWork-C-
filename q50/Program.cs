// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого  элемента
//  или же указание, что такого элемента нет.

// 

//     int GetIntNumberFromConsole(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
int rowIndex = GetIntInput("введите номер строки: ");
int colIndex = GetIntInput("введите номер столбца: ");
int[,] array = new int[2, 3];
ShowPlaceInArray(array, rowIndex, colIndex);


int GetIntInput(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void ShowPlaceInArray(int[,] array, int rowIndex, int colIndex)
{
    Random random = new Random();
for (int row = 0; row < 2; row++)
{
    for (int col = 0; col < 3; col++)
    {
        array[row, col] = random.Next(100);
        Console.Write("{0,9}", array[row, col]);
    }
    Console.WriteLine();
}
    if (rowIndex < array.GetLength(0) && colIndex < array.GetLength(1))
    {
        Console.Write($"значение заданного элемента [{rowIndex},{colIndex}]: {array[rowIndex, colIndex]}");
    }
    else
    {
        Console.Write("заданного элемента нет");
    }
    Console.WriteLine();

}
