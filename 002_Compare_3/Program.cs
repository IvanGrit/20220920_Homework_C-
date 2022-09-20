// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using static System.Console;
Clear();
// Блок ввода чисел 
WriteLine("Input Number #1: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Input Number #2: ");
int b = Convert.ToInt32(ReadLine());
WriteLine("Input Number #3: ");
int c = Convert.ToInt32(ReadLine());
// Сравниваем числа и находим максимальное
int maxNumber = a;
if(maxNumber < b) maxNumber = b;
if(maxNumber < c) maxNumber = c;
Console.WriteLine($"Число {maxNumber} является максимальным из трех введенных");

