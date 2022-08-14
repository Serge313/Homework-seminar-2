int number = GetNumber("Enter your number ");


if (number >= 6 & number <= 7)
{
    Console.WriteLine("Yes");
}
else if (number > 0 & number <= 5)
{
    Console.WriteLine("No");
}
else
{
    Console.WriteLine("Error, choose another number");
}


int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}