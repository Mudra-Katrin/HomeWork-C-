

int randomValue = new Random().Next(100,1000);

int result1 = randomValue / 10;
int result2 = result1 % 10;
Console.WriteLine(randomValue);
Console.WriteLine(result2);