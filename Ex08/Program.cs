Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = 2;
string result = "";
while (b <= a)
{
    if (b <= a - 2) result += b + ", ";
    else result += b;
    b += 2;
}
Console.WriteLine(result);