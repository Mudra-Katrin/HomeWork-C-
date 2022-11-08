// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

// (Округление до 2х знаков после запятой - Math.Round(value, 2))

int n = Prompt("Ввведите количество строк");
int m = Prompt("Ввведите количество столбцов");
double[,]array = CreateArray(n, m, -10, 10);
PrintArray(array);

int Prompt(string massage)
{
    Console.WriteLine(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

bool IsInputLengthValid(int number)
{
    if (number < 0)
        return false;
    return true;
}

double[,] CreateArray(int n, int m, int minValue, int maxValue)
{
    double[,] tmp = new double[n, m];
    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < m; col++)
        {
            tmp[row, col] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 2);
        }
    }
    return tmp;
}

void PrintArray(double[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col< array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col]}");
        }
        Console.WriteLine();

    }
}


