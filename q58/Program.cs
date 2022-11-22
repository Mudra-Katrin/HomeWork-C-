// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.




int lengthOneX = GetPositiveInt("Введите количество строк первой матрицы  : ");
int lengthOneY = GetPositiveInt("Введите количество столбцов первой матрицы : ");
int lengthTwoX = GetPositiveInt("Введите количество строк второй матрицы : ");
int lengthTwoY = GetPositiveInt("Введите количество столбцов второй матрицы : ");

int[,] matrixOne = new int[lengthOneX, lengthOneY];
int[,] matrixTwo = new int[lengthTwoX, lengthTwoY];

FillMatrixRandomNumbers(matrixOne, 0, 10);
FillMatrixRandomNumbers(matrixTwo, 0, 10);

ShowDualLayerArray(matrixOne, "\nматрица первая\n");
Console.WriteLine();
ShowDualLayerArray(matrixTwo, "\nматрица вторая\n");
Console.WriteLine();

if (matrixOne.GetLength(1) == matrixTwo.GetLength(0))
{
    int[,] matrixResult = CompositionMatrix(matrixOne, matrixTwo);
    ShowDualLayerArray(matrixResult, "\nпроизведение матриц One на Two \n");
}
else
{
    Console.WriteLine("\nпроизведение матриц One на Two \nпроизведение не существует");
}


if (matrixTwo.GetLength(1) == matrixOne.GetLength(0))
{
    int[,] matrixResult = CompositionMatrix(matrixTwo, matrixOne);
    ShowDualLayerArray(matrixResult, "\nпроизведение матриц Two на One \n");
}
else
{
    Console.WriteLine("\nпроизведение матриц Б на А \nпроизведение не существует");
}
int GetPositiveInt(string massage)
{
    Console.WriteLine(massage);
    int input;
    while (!int.TryParse(Console.ReadLine(), out input) ^ input < 0)
    {
        Console.Write("Ошибка\n" + massage);
    }
    return input;
}


int[,] CompositionMatrix(int[,] inputMatrixOne, int[,] inputMatrixTwo)
{
    int[,] compositionMatrix = new int[inputMatrixOne.GetLength(0), inputMatrixTwo.GetLength(1)];
    for (int i = 0; i < inputMatrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrixTwo.GetLength(1); j++)
        {
            compositionMatrix[i, j] = 0;
            for (int k = 0; k < inputMatrixOne.GetLength(1); k++)
            {
                compositionMatrix[i, j] += inputMatrixOne[i, k] * inputMatrixTwo[k, j];
            }
        }
    }
    return compositionMatrix;
}


void FillMatrixRandomNumbers(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
}


void ShowDualLayerArray(int[,] inputArray, string text = "", bool IsWithIndex = false)
{
    Console.WriteLine(text);
    for (int row = 0; row < inputArray.GetLength(0); row++)
    {
        for (int col = 0; col < inputArray.GetLength(1); col++)
        {
            Console.Write($"{inputArray[row, col],5}");
            if (IsWithIndex)
            {
                Console.Write($" ({row},{col}) ");
            }
        }
        Console.WriteLine();
    }
}

// int lengthOneX = GetPositiveInt("Введите количество строк первой матрицы  : ");
// int lengthOneY = GetPositiveInt("Введите количество столбцов первой матрицы : ");
// int lengthTwoX = GetPositiveInt("Введите количество строк второй матрицы : ");
// int lengthTwoY = GetPositiveInt("Введите количество столбцов второй матрицы : ");

// int[,] matrixOne = new int[lengthOneX, lengthOneY];
// int[,] matrixTwo = new int[lengthTwoX, lengthTwoY];

// FillMatrixRandomNumbers(matrixOne, 0, 20);
// FillMatrixRandomNumbers(matrixTwo, 0, 20);

// ShowDualLayerArray(matrixOne, "\nматрица первая\n");

// ShowDualLayerArray(matrixTwo, "\nматрица вторая\n");

// if (matrixOne.GetLength(1) == matrixTwo.GetLength(0))
// {
//     int[,] matrixResult = CompositionMatrix(matrixOne, matrixTwo);
//     ShowDualLayerArray(matrixResult, "\nпроизведение матриц A на Б \n");
// }
// else
// {
//     Console.WriteLine("\nпроизведение матриц A на Б \nпроизведение не существует");
// }

// if (matrixTwo.GetLength(1) == matrixOne.GetLength(0))
// {
//     int[,] matrixResult = CompositionMatrix(matrixTwo, matrixOne);
//     ShowDualLayerArray(matrixResult, "\nпроизведение матриц Б на А \n");
// }
// else
// {
//     Console.WriteLine("\nпроизведение матриц Б на А \nпроизведение не существует");
// }

// int GetPositiveInt(string massage)
// {
//     Console.WriteLine(massage);
//     int input;
//     while (!int.TryParse(Console.ReadLine(), out input) ^ input < 0)
//     {
//         Console.Write("Ошибка\n" + massage);
//     }
//     return input;
// }

// int[,] CompositionMatrix(int[,] inputMatrixOne, int[,] inputMatrixTwo)
// {
//     int[,] compositionMatrix = new int[inputMatrixOne.GetLength(0), inputMatrixTwo.GetLength(1)];

//     for (int i = 0; i < inputMatrixOne.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrixTwo.GetLength(1); j++)
//         {
//             compositionMatrix[i, j] = 0;
//             for (int k = 0; k < inputMatrixOne.GetLength(1); k++)
//             {
//                 compositionMatrix[i, j] += inputMatrixOne[i, k] * inputMatrixTwo[k, j];
//             }
//         }
//     }
//     return compositionMatrix;
// }

// void FillMatrixRandomNumbers(int[,] array, int minValue, int maxValue)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
// }

// void ShowDualLayerArray(int[,] inputArray, string text = "", bool IsWithIndex = false)
// {
//     const int SPACE_FOR_PRINT = 5;
//     Console.WriteLine(text);
//     for (int row = 0; row < inputArray.GetLength(0); row++)
//     {
//         for (int col = 0; col < inputArray.GetLength(1); col++)
//         {
//             Console.Write($"{inputArray[row, col],SPACE_FOR_PRINT}");
//             if (IsWithIndex)
//             {
//                 Console.Write($" ({row},{col}) ");
//             }
//         }
//         Console.WriteLine();
//     }
// }