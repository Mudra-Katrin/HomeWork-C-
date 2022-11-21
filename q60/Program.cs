// See https://aka.ms/new-console-template for more information

    /* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    Напишите программу, которая будет построчно выводить массив, 
    добавляя индексы каждого элемента.*/

    int sideOne = GetPositiveInt("Введите размерность 1: ");
    int sideTwo = GetPositiveInt("Введите размерность 2: ");
    int sideThree = GetPositiveInt("Введите размерность 3: ");

    int[,,] array3D = Create3DMassive(sideOne, sideTwo, sideThree);

    ShowThripleLayerArray(array3D, "3D массив ", true);

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

int[,,] Create3DMassive(int size1, int size2, int size3, int minRandom = 0, int maxRandom = 100)
{
    Random rand = new Random();

    int[,,] array = new int[size1, size2, size3];

    int tmp = rand.Next(minRandom, maxRandom);

    HashSet<int> listNum = new HashSet<int>();

    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size3; k++)
            {
                while (listNum.Contains(tmp))
                {
                    tmp = rand.Next(minRandom, maxRandom);
                }
                listNum.Add(tmp);
                array[i, j, k] = tmp;
            }
        }
    }

    return array;
}

const int SPACE_FOR_PRINT = 5;
    void ShowThripleLayerArray<T>(T[,,] inputArray, string text = "", bool IsWithIndex = false)
    {
        Console.WriteLine(text);
        for (int z = 0; z < inputArray.GetLength(2); z++)
        {
            for (int x = 0; x < inputArray.GetLength(0); x++)
            {
                for (int y = 0; y < inputArray.GetLength(1); y++)
                {
                    Console.Write($"{inputArray[x, y, z],SPACE_FOR_PRINT} ");
                    if (IsWithIndex)
                    {
                        Console.Write($" ({x},{y},{z}) ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

