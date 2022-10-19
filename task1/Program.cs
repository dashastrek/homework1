Console.WriteLine ("Write 2 numbers");
string numberA = Console.ReadLine();
string numberB = Console.ReadLine();
int numberAA = int.Parse(numberA);
int numberBB = int.Parse(numberB);
int max = numberAA;
if(numberAA > max) max = numberAA;
if(numberBB > max) max = numberBB;

Console.Write("max= ");
Console.WriteLine(max);

