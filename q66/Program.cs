// Задача 66: Задайте значения M и N. Напишите программу,
 //которая найдёт сумму натуральных элементов в промежутке от M до N.
int n = GetPositiveInt ("Введите начальное число :");
int m = GetPositiveInt ("Введите конечное число :");
if (m<n)
{
     Console.WriteLine("начальное число должно быть меньше конечного");
}
else
{
    Console.WriteLine(SummNumFromNToM(n,m));
}

int GetPositiveInt (string message)
{
    Console.Write(message);
    int value;
    while(! int.TryParse(Console.ReadLine(), out value) ^value < 0) 
    {
        Console.Write("Error\n" + message);
    }
    return value;
}


int SummNumFromNToM( int n, int m) 
{
    
    if ( n < m)
    {   
        return SummNumFromNToM(n+1, m) + n;

    }
    return n;
}