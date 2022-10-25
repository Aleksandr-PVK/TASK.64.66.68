void Task64()
{
    // Задача 64: Задаю значение N. Программа, выводит все натуральные числа в промежутке от N до 1. Выполнено с помощью рекурсии.
    int n = InputInt("Введите положительное число: ");
    int m = 1;
    if (n < 1)
    {
        Console.WriteLine("Вы ввели не положительное число!");
    }
    else
        Console.WriteLine(NaturalNumber(n, m));

    int NaturalNumber(int n, int m)
    {
        if (n == m)
            return n;
        else
            Console.Write($"{NaturalNumber(n, m + 1)}, ");
        return m;
    }

    int InputInt(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }
}

// Задача 66: Задю значения M и N. Программа, ищет сумму натуральных элементов в промежутке от M до N.
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"Сумма элементов от {m} до {n} равна {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}