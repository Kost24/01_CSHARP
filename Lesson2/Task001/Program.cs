// Задание 1. Совместная работа
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

System.Console.Write("Введите трехзначное число");
int number = Convert.ToInt32(Console. ReadLine());

if (number > 99 && number < 1000)
{
    int LeftDigit = number / 100;
    int RightDigit = number % 10;
    int newNumber = LeftDigit * 10 + RightDigit;
    //System.Console.WriteLine(LeftDigit + "" + RightDigit);
    System.Console.WriteLine(newNumber);
}
else 
{
    System.Console.WriteLine(" Введено не трехзначное число");
}


int a = 7;
int b = 9;
System.Console.Write(a + "" + b);

//System.Console.WriteLine($"Значение первой переменной:{a}, значение второй переменной: {b}"); //СТРОКА F

//System.Console.WriteLine("Значение первой переменной:" + a + ",значение второй переменной:" + b);
