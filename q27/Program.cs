// See https://aka.ms/new-console-template for more 
uint number = GetInputUlong("Введите положительное число:");
ulong resoult = SummCharNumber(number);

Console.WriteLine(resoult);

ulong SummCharNumber(uint number)
{
    ulong resoult = 0;
    while (number>0)
    {
        resoult=resoult+(number % 10);
        number= number/10;
    }
    return (resoult);
}
uint GetInputUlong(string text)
{
    Console.Write(text);
    return
uint.Parse(Console.ReadLine());
}