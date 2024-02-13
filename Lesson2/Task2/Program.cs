// Задание 2. Обсуждение решений
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if ( number > 99 && number < 1000)
{
  int midldigit = number % 100 /10;
  int rightDigit = number % 10;
  //int i = 0;
  int result = 1;

    for (; rightDigit > 0; rightDigit --)
    {
        result *= midldigit;
    }

//     while (i < rightDigit)
//   {
//     result = result * midldigit;
//     i ++;

//   }
  
  System.Console.WriteLine(result);
}
else 
{
    System.Console.WriteLine("Ввели не трехзначное число");
}


