// Показать натуральные числа от N до 1, N задано

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string ShowNaturalNumbers (int digit, int n)
{
    if (digit >= n) return $"{digit} " + ShowNaturalNumbers(digit - 1, n); 
    else return String.Empty;
}

int numberN = InputNumber("Enter N: ");
int number = 1;

Console.WriteLine(ShowNaturalNumbers(numberN, number));