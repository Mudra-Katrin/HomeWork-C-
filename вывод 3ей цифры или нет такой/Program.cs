// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите , пожалуйста, целое число");

string value1 = Console.ReadLine();
string myString = value1;
if (value1 >= 100){
    Console.Write (myString[2]);
}   
else
{
    Console.WriteLine ("3 число отсутствует");
}

