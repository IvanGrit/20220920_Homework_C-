// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// Решение №1
//using static System.Console;
//Clear();
//WriteLine("Input Number: ");
//int a = Convert.ToInt32(ReadLine());
//int index = 2;
//Console.WriteLine($"Четными числами в диапзоне от 1 до {a} являются:");
//while(index <= a)
//{
//    Console.Write(index);
//    Console.Write(" ");
//    index+=2;
//}

// Решение №2
using static System.Console;
Clear();
WriteLine("Input Number: ");
int a = Convert.ToInt32(ReadLine());
int index = 1;
Console.WriteLine($"Четными числами в диапзоне от 1 до {a} являются:");
while(index <= a)
{
    if(index % 2 == 0)
    {
        Console.Write(index);
        Console.Write(" ");
    }
    index++;
}

