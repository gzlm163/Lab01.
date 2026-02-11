Console.Write(" Choose task: ");

switch (Console.ReadLine())
{
    case "1":
        int originalNumber;
        int exponent;
        int result;
        int counter;

        Console.Write(" Enter number a: ");
        originalNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Enter exponent: ");
        exponent = Convert.ToInt32(Console.ReadLine());

        result = 1;
