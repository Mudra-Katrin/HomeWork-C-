// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int n = Prompt("Введите количество строк:");
int m = Prompt("Введите количество столбцов:");
int[,] matrix = CreateArray(n, m, 0, 100);
PrintArray(matrix);//метод для печати массива

SortMatrix(matrix);// метод сортировки массива

Console.WriteLine("\nМассив с упорядоченными значениями");

PrintArray(matrix);// метод для вывода массива
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
            Console.Write ($"{inputMatrix[i,j],6}");
            
        }
        Console.WriteLine();
    }
}

void SortMatrix(int[,] matrix)
{
    int index = matrix.GetLength(0);
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }

        }
       
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

