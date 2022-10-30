//Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.

    
    int min = 100;
    int max = 999;

    int[] CreateRandomArray(int N, int min, int max)
    {
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = new Random().Next(min, max + 1);
            return array;
        }
    }

    int PrintAndGetNumber(string massage)
    {
        Console.WriteLine(massage);
        string input = Console.ReadLine();
        int N = int.Parse(input);
        return N;
    }

    int Res (int[] array)
    {
        int res = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) res++;
        }
        return res;
        Console.WriteLine(res);
    }
    int N = PrintAndGetNumber("Введите длину массива");
    
