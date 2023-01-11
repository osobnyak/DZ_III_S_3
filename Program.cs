// Задача 23.
// принимаем число N и выдаём таблицу кубов чисел от 1 до N.

// по моему в задаче не корректный первый пример (при N = 3, возведение в квадрат, а не в куб)

Console.WriteLine("Укажите число N");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
    int[] n2 = new int[n];
    Console.Write("длина массива: ");
    Console.WriteLine(n2.Length);

    for (int i = 0; i < n; i++)
    {
        n2[i] = i + 1;
        Console.Write(n2[i]);
        Console.Write(" в кубе = ");
        Console.WriteLine((i + 1) * (i + 1) * (i + 1));
    }
}

else
    Console.WriteLine("число должно быть больше 0 ");
