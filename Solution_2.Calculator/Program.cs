namespace Solution_2.Calculator
{
    internal class Program
    {
        static void Main()
        {
            IsContinue();
        }

        static void IsContinue()
        {
            for (; ; )
            {
                bool exit = PrintBaseMenu();
                if (exit == true)
                {
                    return;
                }
                Console.WriteLine("Do you want continue? Press Y to continue");
                string? inputToContinue = Console.ReadLine();
                if (inputToContinue != "y" && inputToContinue != "Y")
                {
                    return;
                }
            }
        }

        static bool PrintBaseMenu()
        {
            Console.WriteLine("Select option:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Exponentiation");
            Console.WriteLine("6 - Factorial");
            Console.WriteLine("0 - Exit");


            var selectedFunction = Console.ReadLine();


            if (int.TryParse(selectedFunction, out var function))
            {
                switch (function)
                {
                    case 1:
                        Addition();
                        return false;
                    case 2:
                        Subtraction();
                        return false;
                    case 3:
                        Multiplication();
                        return false;
                    case 4:
                        Division();
                        return false;
                    case 5:
                        Exponentiation();
                        return false;
                    case 6:
                        Factorial();
                        return false;
                    case 0:
                        return true;
                    default:
                        ProcessIncorrectInput();
                        return false;
                }
            }
            else
            {
                ProcessIncorrectInput();
                return false;
            }
        }

        static void Addition()
        {
            Console.WriteLine("Select option:");
            Console.WriteLine("1 - Use random values");
            Console.WriteLine("2 - Write your values");
            Console.WriteLine("0 - Exit");

            var selectedOption = Console.ReadLine();

            if (int.TryParse(selectedOption, out var option))
            {
                switch (option)
                {
                    case 1:

                        var random1 = new Random();
                        var number1 = random1.Next(-1000, 1000);
                        var random2 = new Random();
                        var number2 = random2.Next(-1000, 1000);

                        Console.WriteLine($"Random values : {number1}, {number2}");
                        Console.WriteLine($"Addition : {number1 + number2}");
                        break;

                    case 2:

                        Console.WriteLine("Enter first number:");
                        var inputValue1 = double.TryParse(Console.ReadLine(), out double x1);
                        Console.WriteLine("Enter second number:");
                        var inputValue2 = double.TryParse(Console.ReadLine(), out double y1);

                        if (inputValue1 && inputValue2)
                        {
                            Console.WriteLine($"Addition : {x1 + y1}");
                        }
                        else
                        {
                            Console.WriteLine("Wrong value");
                        }
                        break;
                    case 0:
                        return;
                    default:
                        ProcessIncorrectInput();
                        break;
                }
            }
            else
            {
                ProcessIncorrectInput();
            }


        }

        static void Subtraction()
        {
            Console.WriteLine("Select option:");
            Console.WriteLine("1 - Use random values");
            Console.WriteLine("2 - Write your values");
            Console.WriteLine("0 - Exit");

            var selectedOption = Console.ReadLine();

            if (int.TryParse(selectedOption, out var option))
            {
                switch (option)
                {
                    case 1:
                        var random1 = new Random();
                        var number1 = random1.Next(-1000, 1000);
                        var random2 = new Random();
                        var number2 = random2.Next(-1000, 1000);

                        Console.WriteLine($"Random values : {number1}, {number2}");
                        Console.WriteLine($"Subtraction : {number1 - number2}");
                        break;
                    case 2:
                        Console.WriteLine("Enter first number:");
                        var inputValue1 = double.TryParse(Console.ReadLine(), out double x1);
                        Console.WriteLine("Enter second number:");
                        var inputValue2 = double.TryParse(Console.ReadLine(), out double y1);
                        if (inputValue1 && inputValue2)
                        {
                            Console.WriteLine($"Subtraction : {x1 - y1}");
                        }
                        else
                        {
                            Console.WriteLine("Wrong value");
                        }
                        break;
                    case 0:
                        return;
                    default:
                        ProcessIncorrectInput();
                        break;
                }
            }
            else
            {
                ProcessIncorrectInput();
            }
        }

        static void Multiplication()
        {
            Console.WriteLine("Select option:");
            Console.WriteLine("1 - Use random values");
            Console.WriteLine("2 - Write your values");
            Console.WriteLine("0 - Exit");

            var selectedOption = Console.ReadLine();

            if (int.TryParse(selectedOption, out var option))
            {
                switch (option)
                {
                    case 1:
                        var random1 = new Random();
                        var number1 = random1.Next(-1000, 1000);
                        var random2 = new Random();
                        var number2 = random2.Next(-1000, 1000);

                        Console.WriteLine($"Random values : {number1}, {number2}");
                        Console.WriteLine($"Multiplication : {number1 * number2}");
                        break;
                    case 2:
                        Console.WriteLine("Enter first number:");
                        var inputValue1 = double.TryParse(Console.ReadLine(), out double x1);
                        Console.WriteLine("Enter second number:");
                        var inputValue2 = double.TryParse(Console.ReadLine(), out double y1);
                        if (inputValue1 && inputValue2)
                        {
                            Console.WriteLine($"Multiplication : {x1 * y1}");
                        }
                        else
                        {
                            Console.WriteLine("Wrong value");
                        }
                        break;
                    case 0:
                        return;
                    default:
                        ProcessIncorrectInput();
                        break;
                }
            }
            else
            {
                ProcessIncorrectInput();
            }
        }

        static void Division()
        {
            Console.WriteLine("Select option:");
            Console.WriteLine("1 - Use random values");
            Console.WriteLine("2 - Write your values");
            Console.WriteLine("0 - Exit");

            var selectedOption = Console.ReadLine();

            if (int.TryParse(selectedOption, out var option))
            {
                switch (option)
                {
                    case 1:
                        var random1 = new Random();
                        double number1 = random1.Next(-1000, 1000);
                        var random2 = new Random();
                        double number2 = random2.Next(-1000, 1000);

                        Console.WriteLine($"Random values : {number1}, {number2}");
                        if (number2 == 0)
                        {
                            Console.WriteLine("You can't divide by 0");
                        }
                        else
                        {
                            Console.WriteLine($"Division : {number1 / number2}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter first number:");
                        var inputValue1 = double.TryParse(Console.ReadLine(), out double x1);
                        Console.WriteLine("Enter second number:");
                        var inputValue2 = double.TryParse(Console.ReadLine(), out double y1);
                        if (inputValue1 && inputValue2)
                        {
                            if (y1 == 0.0)
                            {
                                Console.WriteLine("You can't divide by 0");
                            }
                            else
                            {
                                Console.WriteLine($"Division : {x1 / y1}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong value");
                        }
                        break;
                    case 0:
                        return;
                    default:
                        ProcessIncorrectInput();
                        break;
                }
            }
            else
            {
                ProcessIncorrectInput();
            }
        }

        static void Exponentiation()
        {
            Console.WriteLine("Select option:");
            Console.WriteLine("1 - Use random values");
            Console.WriteLine("2 - Write your values");
            Console.WriteLine("0 - Exit");

            var selectedOption = Console.ReadLine();

            if (int.TryParse(selectedOption, out var option))
            {
                switch (option)
                {
                    case 1:
                        var random1 = new Random();
                        var number1 = random1.Next(0, 100);
                        var random2 = new Random();
                        var number2 = random2.Next(0, 100);
                        Console.WriteLine($"Random values : {number1}, {number2}");
                        Console.WriteLine(value: $"Exponentiation : {Math.Pow(number1, number2)}");
                        break;
                    case 2:
                        Console.WriteLine("Enter first number:");
                        var inputValue1 = double.TryParse(Console.ReadLine(), out double x1);
                        Console.WriteLine("Enter second number:");
                        var inputValue2 = double.TryParse(Console.ReadLine(), out double y1);
                        if (inputValue1 && inputValue2)
                        {
                            Console.WriteLine(value: $"Exponentiation : {Math.Pow(x1, y1)}");
                        }
                        else
                        {
                            Console.WriteLine("Wrong value");
                        }
                        break;
                    case 0:
                        return;
                    default:
                        ProcessIncorrectInput();
                        break;
                }
            }
            else
            {
                ProcessIncorrectInput();
            }
        }

        static void Factorial()
        {
            Console.WriteLine("Select option:");
            Console.WriteLine("1 - Use random value");
            Console.WriteLine("2 - Write your value");
            Console.WriteLine("0 - Exit");

            var selectedOption = Console.ReadLine();

            if (int.TryParse(selectedOption, out var option))
            {
                switch (option)
                {
                    case 1:
                        var random1 = new Random();
                        var number1 = random1.Next(0, 12);
                        Console.WriteLine($"Random value : {number1}");
                        if (number1 == 0)
                        {
                            Console.WriteLine($"Factorial: 1");
                        }
                        else
                        {
                            int Factorial(int number1)
                            {
                                if (number1 == 1) return 1;
                                return number1 * Factorial(number1 - 1);
                            }
                            Console.WriteLine($"Factorial : {Factorial(number1)}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter number, if number > 12, then result will be out of range:");
                        var inputValue1 = int.TryParse(Console.ReadLine(), out int x1);

                        if (inputValue1)
                        {
                            if (x1 < 0)
                            {
                                Console.WriteLine("Wrong value");
                            }
                            else if (x1 == 0)
                            {
                                Console.WriteLine($"Factorial: 1");
                            }
                            else if (x1 > 12)
                            {
                                Console.WriteLine("Out of range");
                            }
                            else
                            {
                                int Factorial(int x1)
                                {
                                    if (x1 == 1) return 1;
                                    return x1 * Factorial(x1 - 1);
                                }
                                Console.WriteLine($"Factorial: {Factorial(x1)}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong value");
                        }
                        break;
                    case 0:
                        return;
                    default:
                        ProcessIncorrectInput();
                        break;
                }
            }
            else
            {
                ProcessIncorrectInput();
            }
        }

        static void ProcessIncorrectInput()
        {
            Console.WriteLine("Incorrect input");
            PrintBaseMenu();
        }

    }
}