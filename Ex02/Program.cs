Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine() ?? "0");
if (a > b) Console.Write($"max == {a} min =={b}");
else if (a == b) Console.Write($"Числа равны");
else Console.Write($"max == {b} min =={a}");