Console.Write("Введите n:");
int n = int.Parse(Console.ReadLine());
int a = n / 100;
int b = (n / 10) % 10;
int c = n % 10;

Console.WriteLine("Все перестановки:");
Console.WriteLine($"{a}{b}{c}");
Console.WriteLine($"{a}{c}{b}");
Console.WriteLine($"{b}{a}{c}");
Console.WriteLine($"{b}{c}{a}");
Console.WriteLine($"{c}{a}{b}");
Console.WriteLine($"{c}{b}{a}");