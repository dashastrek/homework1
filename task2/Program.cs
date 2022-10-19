/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine ("Write 3 numbers");
string numberA = Console.ReadLine();
string numberB = Console.ReadLine();
string numberC = Console.ReadLine();
int numberAA = int.Parse(numberA);
int numberBB = int.Parse(numberB);
int numberCC = int.Parse(numberC);
int max = numberAA;
if(numberAA > max) max = numberAA;
if(numberBB > max) max = numberBB;
if(numberCC > max) max = numberCC;

Console.Write("max= ");
Console.WriteLine(max);