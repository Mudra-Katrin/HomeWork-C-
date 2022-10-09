Console.WriteLine("Введите число x");
string value = Console.ReadLine();

Console.WriteLine("Введите число y");
string value2 = Console.ReadLine();

Console.WriteLine("Введите число z");
string value3 = Console.ReadLine();

int x = int.Parse(value);
int z = int.Parse(value3);
int y = int.Parse(value2);

int max = x;

if (x > y) max = x;
if (y > x) max = y;
if (z > y) max = z;
Console.Write("max = "); 
Console.WriteLine(max); 
