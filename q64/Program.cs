// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от N до 1.
 //Выполнить с помощью рекурсии.

int n = GetPositiveInt ("Введите число:");

if (n<=1)
{
     Console.WriteLine("число должно быть положительное");
}
else
{
    Console.WriteLine(ShowNumFromNToOne(n));
}

int GetPositiveInt (string message)
{
    Console.Write(message);
    int value;
    while(! int.TryParse(Console.ReadLine(), out value) )
    {
        Console.Write("Error\n" + message);
    }
    return value;
}

string ShowNumFromNToOne ( int number, int start=1)
{
    //Console.Write(number);
    string tmp = string.Empty;
    if ( number>=start)
    {
        return $"{number},{ShowNumFromNToOne(--number, start)}";

    }
    return tmp ;
}
