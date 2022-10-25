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