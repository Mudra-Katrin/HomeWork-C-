// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
int n = Prompt("Введите количество строк:");
int m = Prompt("Введите количество столбцов:");
int[,] matrix = CreateArray(n, m, 0, 10);
PrintArray(matrix);//метод для печати массива
if (matrix.GetLength(0) == matrix.GetLength(1))
{
    Console.WriteLine("Введите количество строк не равное количеству столбцов");
}
else
{
    MinSumRowArray(matrix);// метод нахождения минимальной суммы элементов строки
                           //OutputManager.ShowDualLayerArray(sqareArray);

}
void MinSumRowArray(int[,] matrix)
{
    int minSum = int.MaxValue;
    int rowIndex = 0;
    for (int row = 0; row < n; row++)
    {
        int sum = 0;
        for (int col = 0; col < m; col++)
        {
            sum = sum + matrix[row, col];//считает сумму в каждой строчке
        }
        if (sum < minSum) //если сумма меньше минимальной суммы, 
        //то переходим к следущей строке и присваиваем минимальной сумме ту,
        //что получилось в преведущей строке
        {
            rowIndex = row + 1;
            minSum = sum;
            Console.WriteLine($"№ {rowIndex}\nCумма элементов {minSum}");
        }

        
    }


    Console.WriteLine($"Строка с наименьшей суммой № {rowIndex}\nCумма элементов {minSum}");
}

//PrintArray(matrix);// метод для вывода массива


int[,] CreateArray(int n, int m, int minValue, int maxValue)// метод создания рандомного массива
{
    int[,] tmp = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            tmp[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return tmp;
}
void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write($"{inputMatrix[i, j],6}");

        }
        Console.WriteLine();
    }
}


int Prompt(string massage)
{
    Console.WriteLine(massage);
    int result;
    while (!int.TryParse(Console.ReadLine(), out result) ^ result < 0)
    {
        Console.Write("Error \n" + massage);
    }
    return result;
}

