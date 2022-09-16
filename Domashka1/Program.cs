Console.WriteLine("Задание 1. Вывести натуральный логарифм ");
double x = Math.E;
Console.WriteLine("E={0:F1}", x);

Console.WriteLine("Задание 2. Вывести 50 и 10 ");
Console.WriteLine(50);
Console.WriteLine(10);

Console.WriteLine("Задание 3. Вывести 4 любых числа в столбик");
Console.WriteLine("Введите 4 числа:");
string input = Console.ReadLine();
string[] output = input.Split(' ');
foreach (var a in output)
{
    Console.WriteLine(a);
}

Console.WriteLine("Задание 4. Вывести number+10");
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()); //перевод из строки в инт
Console.WriteLine(number + 10);

Console.WriteLine("Задание 5. Найти периметр квадрата");
Console.WriteLine("Введите сторону квадрата:");
int side = int.Parse(Console.ReadLine());
Console.WriteLine("Периметр квадрата: " + side * 4);

Console.WriteLine("Задание 6. Длина и площадь круга");
Console.WriteLine("Введите радиус круга:");
int radius = int.Parse(Console.ReadLine());
double pi = Math.PI; // число пи
Console.WriteLine("Длина окружности: " + Math.Round(2 * pi * radius));
Console.WriteLine("Плоащадь окружности: " + Math.Round(pi * radius * radius));