// задача 4
Console.Write("Ввидите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввидите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввидите третье число ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > a)
    max = b;
if (c > max)
    max = c;

Console.WriteLine("{0} наибольшее число", max);
