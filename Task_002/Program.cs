// Показать натуральные числа от M до N, N и M заданы

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string StartMN(int digitM, int digitN)
{
    if (digitM <= digitN) return $"{digitM} " + StartMN(digitM + 1, digitN);
    return String.Empty;
}

string FinishMN(int digitM, int digitN)
{
    if (digitM >= digitN) return $"{digitM} " + FinishMN(digitM - 1, digitN);
    return String.Empty;
}

int numberM = InputNumber("Enter M: ");
int numberN = InputNumber("Enter N: ");

if (numberM <= numberN) 
    Console.WriteLine(StartMN(numberM, numberN));
else if (numberM > numberN)
    Console.WriteLine(FinishMN(numberM, numberN));