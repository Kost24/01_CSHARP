// Задание 3. Работа в сессионных залах
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

System.Console.Write("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % secondNumber == 0)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет," + firstNumber % secondNumber);
}
