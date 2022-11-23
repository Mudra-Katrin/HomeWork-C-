//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.;
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29" + "\n");


int m = GetPositiveInt("Введите целое число M:");
int n = GetPositiveInt("Введите целое N:");


Console.WriteLine($"m = {m}, n = {n} => A({m},{n})={AkkermanFunction(m, n)}");

int AkkermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return AkkermanFunction(m - 1, 1);
    else
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

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