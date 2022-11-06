// а в степени в без метода M
double a = GetNumberFromConsole("Введите число ");
double b = GetNumberFromConsole("Введите степень для числа ");
MyPow (a,b);

double GetNumberFromConsole(string message)
{
    Console.Write(message);
    double number = double.Parse(Console.ReadLine());
    return number;
}

void MyPow(double number1, double pow)
{
    double resoult = 1;
    for (int i = 0; i < pow; i++)
    {
resoult = resoult * number1;
    }
Console.WriteLine(resoult);
}