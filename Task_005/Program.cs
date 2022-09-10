// Написать программу вычисления функции Аккермана

int m = InputInt("Enter M: ");
int n = InputInt("Enter N: ");
Console.WriteLine($"calculation Ackerman function({m}, {n}) = {Ackerman(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Ackerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Ackerman(m - 1, 1);
    else
        return Ackerman(m - 1, Ackerman(m, n - 1));
}