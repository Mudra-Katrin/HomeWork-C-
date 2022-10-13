//Задача 19
//Напишите программу,которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.

bool IsPalindrome(int number){
    int reverseNumber = ReverseNumber(number);
    bool isEqual = reverseNumber == number;
    return isEqual;
}

int  ReverseNumber(int number){
    int reverseNumber = 0;
    while(number > 0){
         reverseNumber =  reverseNumber*10 + number %10;
         number /=10;

    }
    return reverseNumber;
}

bool IsNumberVaid(int number){
    if(number < 10000 || number > 99999)
          return false;

    return true;      
}

int Promt(){
    Console.WriteLine("Введите 5-значное число!");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = Promt();
if (IsNumberVaid(number)){
    if(IsPalindrome(number))
        Console.WriteLine("Yes");
    else
       Console.WriteLine("No");     
}
else{
    Console.WriteLine("Error");
}

