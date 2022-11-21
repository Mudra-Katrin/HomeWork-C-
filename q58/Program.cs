// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.




int lengthOneX = GetPositiveInt("Введите количество строк первой матрицы  : ");
int lengthOneY = GetPositiveInt("Введите количество столбцов первой матрицы : ");
int lengthTwoX = GetPositiveInt("Введите количество строк второй матрицы : ");
int lengthTwoY = GetPositiveInt("Введите количество столбцов второй матрицы : ");

int[,] matrixOne = new int[lengthOneX, lengthOneY];
int[,] matrixTwo = new int[lengthTwoX, lengthTwoY];

FillMatrixRandomNumbers(matrixOne, 0, 100);
FillMatrixRandomNumbers(matrixTwo, 0, 100);

ShowDualLayerArray(matrixOne, "матрица первая\n");
Console.WriteLine();
ShowDualLayerArray(matrixTwo, "матрица вторая\n");
Console.WriteLine();

if (matrixOne.GetLength(1) == matrixTwo.GetLength(0))
{
    int[,] matrixResult = CompositionMatrix(matrixOne, matrixTwo);
    ShowDualLayerArray(CompositionMatrix, " произведение матриц\n");
}
else
    {
        Console.WriteLine("произведение не существует");
    }


int GetPositiveInt(string massage)
{
    Console.WriteLine(massage);
    int input = int.Parse(Console.ReadLine());
    return input;
}

//int[,] resultMatrix = CompositionMatrix(matrixOne, matrixTwo);
int CompositionMatrix(int[,] matrixOne, int lengthOneX, int[,] matrixTwo, int lengthTwoY)
{
    
        int compositionMatrix = 0;
    for (int lengthOneY = 0; lengthOneY < matrixOne.GetLength(1); lengthOneY++) ;
    {
        for (int lengthTwoX = 0; lengthTwoX < matrixTwo.GetLength(0); lengthTwoX++) ;
        {
            compositionMatrix = compositionMatrix + matrixOne[lengthOneX, lengthOneY] * matrixTwo[lengthTwoX, lengthTwoY];
            lengthOneY++;
        }
    }
    return compositionMatrix;
    
}


void FillMatrixRandomNumbers(int[,] array,int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue,maxValue+1);
        }
    }
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