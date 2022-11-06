// Напишите программу, которая принимает на вход число N и выдает таблицу кубов
//и выдает таблицу кубов
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

for(int i = 1; i <= N; i++) {
    Console.Write($"{Math.Pow(i, 3)}{(i != N ? "," : "\n")}");
}
