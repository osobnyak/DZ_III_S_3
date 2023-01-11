// Задача 19. принимаем 5 значное число и проверяем палиндром ли оно.

Console.WriteLine("введите 5 значное число:");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 99999 || n < 10000)
{
    Console.WriteLine("число должно быть 5 значным...");
}
else
{
    int n1 = n / 10000;
    Console.Write("первая цифра = ");
    Console.WriteLine(n1);

    int n2 = (n - (n1 * 10000)) / 1000;
    Console.Write("вторая цифра = ");
    Console.WriteLine(n2);

    int n3 = (n - (n1 * 10000) - (n2 * 1000)) / 100;
    Console.Write("третья цифра = ");
    Console.WriteLine(n3);

    int n4 = (n - (n1 * 10000) - (n2 * 1000) - (n3 * 100)) / 10;
    Console.Write("четвёртая цифра = ");
    Console.WriteLine(n4);

    int n5 = n % 10;
    Console.Write("пятая цифра = ");
    Console.WriteLine(n5);

    if ((n5 == n1) || (n4 == n2))
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("НЕТ");
    }
}