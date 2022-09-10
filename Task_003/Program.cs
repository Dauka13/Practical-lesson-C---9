// Найти сумму элементов от M до N, N и M заданы

int m = InputInt("Enter M: ");
int n = InputInt("Enter N: ");
Console.WriteLine($"Sum of elements from {m} to {n} = {CountNaturalSum(m, n)}");

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