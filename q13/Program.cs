// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите , пожалуйста, целое число");

string value1 = Console.ReadLine();
string myString = value1.Trim('-');

if (myString.Length < 3){
    Console.WriteLine ("третье число отсутствует");
}   
else
{
    Console.Write (myString[2]);
}

