// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int sizeArrayX = GetPositiveInt("Введите размер массива: ");

    int[,] spiralArray = new int[sizeArrayX, sizeArrayX];

    int numberForSpiralArray = 1;
    int x = 0;
    int y = 0;

    while (numberForSpiralArray <= sizeArrayX * sizeArrayX)
    {
        spiralArray[x, y] = numberForSpiralArray;
        if (x <= y + 1 && x + y < sizeArrayX - 1) y++;
        else if (x < y && x + y >= sizeArrayX - 1) x++;
        else if (x >= y && x + y > sizeArrayX - 1) y--;
        else x--;
        numberForSpiralArray++;
    }

    
ShowDualLayerArray(spiralArray, "Спиралька ");


int GetPositiveInt(string message)
{
    Console.Write(message);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) ^ value < 0)
    {
        Console.Write("Error\n" + message);
    }
    return value;
}
const int SPACE_FOR_PRINT = 5;
void ShowDualLayerArray<T>(T[,] inputArray, string text = "", bool IsWithIndex = false)
    {
        Console.WriteLine(text);
        for (int row = 0; row < inputArray.GetLength(0); row++)
        {
            for (int col = 0; col < inputArray.GetLength(1); col++)
            {
                Console.Write($"{inputArray[row, col],SPACE_FOR_PRINT}");
                if (IsWithIndex)
                {
                    Console.Write($" ({row},{col}) ");
                }
            }
            Console.WriteLine();
        }}
        