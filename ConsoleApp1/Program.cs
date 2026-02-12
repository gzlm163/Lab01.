Console.Write(" Choose task: ");

switch (Console.ReadLine()) {
  case "1":
    int originalNumber;
    int exponent;
    int result;

    Console.Write(" Enter the base number: ");
    originalNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write(" Enter exponent: ");
    exponent = Convert.ToInt32(Console.ReadLine());

    result = 1;

    for (int iterationСounter = 0; iterationСounter < exponent; ++iterationСounter) {
      result *= originalNumber;
    }

    Console.WriteLine($" Result: {originalNumber}^{exponent} = {result} ");

    break;

  case "2":
    string inputNumber;
    string resultNumber;
    char secondDigit;

    Console.Write(" Enter number x (x >= 100): ");
    inputNumber = Console.ReadLine();

    secondDigit = inputNumber[1];
    resultNumber = inputNumber[0] + inputNumber.Substring(2) + secondDigit;

    Console.WriteLine($" Result: n = {resultNumber} ");

    break;
}

Console.ReadKey();
