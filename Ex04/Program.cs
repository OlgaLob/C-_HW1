Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine() ?? "0");
int max = int.MinValue;
max = max > a ? max : a;
if (max > a) max = max;
else max = a;
max = max > b ? max : b;
max = max > c ? max : c;
Console.WriteLine(("Максимальное значение ") + (max));