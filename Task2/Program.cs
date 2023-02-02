Console.Clear();

Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if (a > max) max = a;
if (b > max) max = b;
if (a < max) min = a;
if (b < max) min = b;
 
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);