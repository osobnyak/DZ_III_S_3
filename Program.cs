// Задача 21. принимаем на входе координаты 2-х точек и 
//находим расстояние между ними в 3Д пространстве.
//√ (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2

Console.WriteLine("Укажите Х первой точки");
int xA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите Y первой точки");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите Z первой точки");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите Х второй точки");
int xB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите Y второй точки");
int yB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите Z второй точки");
int zB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine($"A({xA},{yA},{zA}); B({xB},{yB},{zB})");
Console.WriteLine("");

double d = 0;
d = Math.Sqrt((Math.Pow((xA-xB), 2) + (Math.Pow((yA-yB), 2) + (Math.Pow((zA-zB), 2))))); 
Console.Write("Расстояние между точками = ");
Console.WriteLine(Math.Round(d, 2));

