string number = GetNumber("Enter your number ");


if (number.Length > 2)
{
    Console.WriteLine(number[2]);
    Console.WriteLine(number.Length);
}
else if (number.Length <= 2)
{
    Console.WriteLine("There is no third digit");
}


string GetNumber(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}