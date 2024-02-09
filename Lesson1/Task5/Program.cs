
// Дано натуральное число N. Вывести на экран числа от 1 до N.


// int n = 100;
// int i = 1;



// while (i <= n) 
//     {
//     //  Console.Write(n + " ");
//     //  Console.Write(i);
//      Console.Write(i + " ");
//       i = i + 1;
//     }

//     Задачка!!!!!!

//  Вход принимает число (number),
//  а на выходе выводит все чётные числа от 1 до number (включительно), 
//  после каждого числа должен быть знак пробела.

System.Console.Write("Введите число");
int N = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i <= N; i ++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");

    }

}




