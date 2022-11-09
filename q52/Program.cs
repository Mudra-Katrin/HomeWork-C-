// //Задача 52. Задайте двумерный массив из целых чисел.
// // Найдите среднее арифметическое элементов в каждом столбце.
int n = Prompt("Ввведите количество строк");
int m = Prompt("Ввведите количество столбцов");
int[,] array = CreateArray(n, m, 0, 100);
int[] summ = new int[m];
// int[,] element = new int[n, m];
// MidleSummaInCol (element);
// Summa int (int[,]b);
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

int[,] CreateArray(int n, int m, int minValue, int maxValue)
{
    int[,] tmp = new int[n, m];
    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < m; col++)
        {
            tmp[row, col] = new Random().Next(minValue, maxValue);
        }
    }
    return tmp;
}

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write("{0,9}", array[row, col]);
            //Console.Write($"{array[row, col]}");
            summ[col] += array[row, col];
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
foreach (double elem in summ)
{
    Console.Write("{0,9}", Math.Round(elem / n, 2));
    //вывод среднего для колонки
}

Console.WriteLine();

