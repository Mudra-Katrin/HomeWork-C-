// See https://aka.ms/new-console-template for more information
int startWeek =1;
int finishWeek =7;

Console.WriteLine("Введите номер дня недели:");

int numberDayWeek = int.Parse(Console.ReadLine());
if (numberDayWeek>=startWeek || numberDayWeek<=finishWeek);{
    if(numberDayWeek >=6){
    Console.WriteLine("Данный день выходной");
}
else{
    Console.WriteLine("Данный день будний");
}
}    