

Console.WriteLine("Введите число x");
string value = Console.ReadLine();
Console.WriteLine("Введите число y");
string value2 = Console.ReadLine();
int x = int.Parse(value);
int y = int.Parse(value2);
int max = x;
if (x > y) max = x;
if (y > x) max = y;
Console.WriteLine(max);    

