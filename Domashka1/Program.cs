
Console.WriteLine("\nЗадание 14. Вывести 2кг 13 17");
Console.WriteLine("2kg");
Console.WriteLine("13 17");

Console.WriteLine("\n3адание 15. Вывести столбиком 4 рандомных числа");
Random lmao = new Random();
int a = lmao.Next();
int b = lmao.Next();
int c = lmao.Next();
int d = lmao.Next();
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);

Console.WriteLine("\nZadanieeeeeeee 16. Найти корни квадратного уравнения");
Console.WriteLine("Task 15 (Введите a:)");
float a_16 = float.Parse(Console.ReadLine());
Console.WriteLine("Task 15 (Введите b:)");
float b_16 = float.Parse(Console.ReadLine());
Console.WriteLine("Task 15 (Введите c:)");
float c_16 = float.Parse(Console.ReadLine());
if ((b_16 * b_16 - 4 * a_16 * c_16) > 0)
{
    Console.WriteLine($"x_1 = {(-b_16 + Math.Sqrt(b_16 * b_16 - 4 * a_16 * c_16)) / (2 * a_16)}");
    Console.WriteLine($"x_1 = {(-b_16 - Math.Sqrt(b_16 * b_16 - 4 * a_16 * c_16)) / (2 * a_16)}");
}
if (b_16 * b_16 - 4 * a_16 * c_16 == 0)
{
    Console.WriteLine($" x = {(-b_16 + Math.Sqrt(b_16 * b_16 - 4 * a_16 * c_16)) / (2 * a_16)}");
}
if (b_16 * b_16 - 4 * a_16 * c_16 < 0)
{
    Console.WriteLine("Prostite дядя или тётя таково нет");
}


Console.WriteLine("\nЗадание 17. Среднее геом и арифм");
Console.WriteLine("Введите первое число:");
float num_1 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
float num_2 = float.Parse(Console.ReadLine());
Console.WriteLine($"Cр. арифм = {(num_1 + num_2) / 2}");
Console.WriteLine($"Cр. геом = {Math.Sqrt(num_1 * num_2)}");

// AB = √(xb - xa)2 + (yb - ya)2
Console.WriteLine("\nЗадание 18. ot x1y1 do x2y2:");
Console.WriteLine("x1:");
float x_1 = float.Parse(Console.ReadLine());
Console.WriteLine("y1:");
float y_1 = float.Parse(Console.ReadLine());
Console.WriteLine("x2:");
float x_2 = float.Parse(Console.ReadLine());
Console.WriteLine("y2:");
float y_2 = float.Parse(Console.ReadLine());
Console.WriteLine($"skol`ko rasstoyaniye: {Math.Sqrt((x_2 - x_1) * (x_2 - x_1) + (y_2 - y_1) * (y_2 - y_1))}");

Console.WriteLine("\nЗадание 19. Смена 3 чисел:");
Console.WriteLine("");


Console.WriteLine("\nЗадание 20. Прошло н секунд было два козла сколько:");
Console.WriteLine("Сколько прошло секунд:");
float seconds = float.Parse(Console.ReadLine());
Console.WriteLine($"Days: {seconds / 3600}");
Console.WriteLine($"From the beginning of the hour: {seconds / 3600}");