Console.WriteLine("\nЗадание 1. Вывести натуральный логарифм ");
double x = Math.E;
Console.WriteLine("E={0:F1}", x);

Console.WriteLine("\nЗадание 2. Вывести 50 и 10 ");
Console.WriteLine(50);
Console.WriteLine(10);

Console.WriteLine("\nЗадание 3. Вывести 4 любых числа в столбик");
Console.WriteLine("Введите 4 числа:");
string input = Console.ReadLine();
string[] output = input.Split(' ');
foreach (var k in output)
{
    Console.WriteLine(k);
}

Console.WriteLine("\nЗадание 4. Вывести number+10");
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()); //перевод из строки в инт
Console.WriteLine(number + 10);

Console.WriteLine("\nЗадание 5. Найти периметр квадрата");
Console.WriteLine("Введите сторону квадрата:");
int side = int.Parse(Console.ReadLine());
Console.WriteLine("Периметр квадрата: " + side * 4);

Console.WriteLine("\nЗадание 6. Найти длину и площадь круга");
Console.WriteLine("Введите радиус круга:");
int radius = int.Parse(Console.ReadLine());
double pi = Math.PI; // число пи
Console.WriteLine("Длина окружности: " + Math.Round(2 * pi * radius));
Console.WriteLine("Плоащадь окружности: " + Math.Round(pi * radius * radius));

Console.WriteLine("\nЗадание 7. Вывести косинус");
Console.WriteLine("Введите значение Х:");
int corner = int.Parse(Console.ReadLine());
Console.WriteLine("Значение косинуса равно: " + Math.Cos(corner));

Console.WriteLine("\nЗадание 8. Найти периметр трапеции ");
Console.WriteLine("Введите значение высоты:");
int h = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение верхнего основания:");
int upper_f = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение нижнего основания:");
int lower_f = int.Parse(Console.ReadLine());
Console.WriteLine("Периметр равен: " + (Math.Sqrt(Math.Pow((lower_f - upper_f) / 2, 2) + Math.Pow(h, 2))) * 2 + lower_f + upper_f);

Console.WriteLine("\nЗадание 9. Итог покупки");
Console.WriteLine("Вес яблок:");
int apples = int.Parse(Console.ReadLine());
Console.WriteLine("Вес конфет:");
int candies = int.Parse(Console.ReadLine());
Console.WriteLine("Вес печенья:");
int cookies = int.Parse(Console.ReadLine());
Console.WriteLine("Итого: " + (apples * 50 + candies * 76 + cookies * 100));


Console.WriteLine("\nЗадание 10. Мир Труд Май");
Console.WriteLine("Мар Труд Май");
Console.WriteLine("Мир");
Console.WriteLine("{0,7}", "Труд");
Console.WriteLine("{0,10}", "Май");

Console.WriteLine("\nЗадание 11. Поменять числа местами");
Console.WriteLine("Введите первое число:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = int.Parse(Console.ReadLine());


Console.WriteLine("\nЗадание 12. Фигура и её периметр|прощадь");
Console.WriteLine("Выберите фигуру:");
Console.WriteLine("Треугольник - 1, квадрат - 2, круг - 3.");
int figure = int.Parse(Console.ReadLine());
Console.WriteLine("Что нужно найти:");
Console.WriteLine("Периметр - 1, площадь - 2");
int find = int.Parse(Console.ReadLine());
double num_pi = Math.PI;
if (figure == 1)
{
    Console.WriteLine("Введите сторону треугольника:");
    float tr_side1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Введите сторону треугольника:");
    float tr_side2 = float.Parse(Console.ReadLine());
    Console.WriteLine("Введите основание треугольника:");
    float tr_osn = float.Parse(Console.ReadLine());
    Console.WriteLine("Введите высоту треугольника:");
    float hei = float.Parse(Console.ReadLine());
    if (find == 1)
    {
        Console.WriteLine($"Периметр Треугольника = {tr_side1 + tr_side2 + tr_osn}");
    }
    if (find == 2)
    {
        Console.WriteLine($"Площадь Треугольника = {(tr_osn * hei) / 2}");
    }
}
if (figure == 2)
{
    Console.WriteLine("Введите сторону квадрата:");
    float sq_side = float.Parse(Console.ReadLine());
    if (find == 1)
    {
        Console.WriteLine($"Периметр квадрата = {sq_side * 4}");
    }
    if (find == 2)
    {
        Console.WriteLine($"Площадь квадрата = {sq_side * sq_side}");
    }
}
if (figure == 3)
{
    Console.WriteLine("Введите радиус круга:");
    float rad = float.Parse(Console.ReadLine());
    if (find == 1)
    {
        Console.WriteLine($"Периметр Круга = {rad * 2 * num_pi}");
    }
    if (find == 2)
    {
        Console.WriteLine($"Площадь Круга = {Math.Round(num_pi * rad * rad)}");
    }
}


Console.WriteLine("\nЗадание 13. Фигура и её периметр|прощадь");
Console.Write("Введите число: ");
double numb = double.Parse(Console.ReadLine());
Console.WriteLine($"Вы ввели число {numb}");


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
Console.WriteLine($"From the beginning of the hour: ");

Console.WriteLine("\nЗадание 21. Сколько квадратов можно вырезать из прямоугольника 543х130:");
Console.WriteLine($"Можно отрезать {543 / 130} квадратов");


Console.WriteLine("\nЗадание 22. Смена позиций в 3-хзначном числе:");
Console.WriteLine("Ведите трёхзначное число:");
string trix = Console.ReadLine();
Console.WriteLine($"{trix[2]}{trix[1]}{trix[0]}");


Console.WriteLine("\nЗадание 23. Число сотен и тысяч в числе:");
int cchis = int.Parse(Console.ReadLine());
Console.WriteLine($"Сотни: {cchis / 100}");
Console.WriteLine($"Тысячи: {cchis / 1000}");

Console.WriteLine("\nЗадание 24. Формирование новых чисел:");
