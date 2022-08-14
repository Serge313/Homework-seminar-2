int number = GetNumber("Enter your number ");
int result = DelDigits(number);
Console.WriteLine(result);

int DelDigits(int a)
{
    return ((a % 100) / 10);
}


int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}