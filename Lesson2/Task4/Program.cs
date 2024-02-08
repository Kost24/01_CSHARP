// Задание 4*
// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while (number > 999)
    {
        number /= 10;
    }
    System.Console.WriteLine(number % 10);

    // int result = number % 1000 / 100;
    // System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("В числе отсутствует третье число");
}
