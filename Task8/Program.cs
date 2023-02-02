Console.Clear();

Console.Write("Введите цифру любую положительную цифру: ");
int n = int.Parse (Console.ReadLine());
for (int i = 2; i <= n; i += 2)
Console.WriteLine(i);