// Variable Declarations
int choice = 0;
int num1, num2 = 0;
int answer = 0;
int calculatorRestart = 0;

// Show calculator options / Show menu
while (choice != -1)
{
    try
    {
        // Welcome Message
        Console.Clear();
        Console.WriteLine("******** - Welcome to the sample calculator! - ********");
        Console.WriteLine("Please select an operation (-1 to exit program)\r\n");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Fibonacci sequence\r\n");

        choice = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        if (choice == -1)
        {
            Console.Clear();
            break;
        }
        if (choice < 1 || choice > 5)
        {
            Console.WriteLine("Invalid Menu Item Selected. Please try again!");
            Thread.Sleep(1000);
            Console.Clear();
            continue;
        }

        Console.Write("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\r\n");

        // Decide which operation is needed based on selected option

        switch (choice)
        {
            case 1:
                Console.WriteLine($"You are adding {num1} to {num2}\r\n");
                Console.WriteLine($"Your operation is: {num1} + {num2}\r\n");
                answer = num1 + num2;
                break;
            case 2:
                Console.WriteLine($"You are subtracting {num2} from {num1}\r\n");
                Console.WriteLine($"Your operation is: {num1} - {num2}\r\n");
                answer = num1 - num2;
                break;
            case 3:
                Console.WriteLine($"You are multiplying {num1} and {num2}\r\n");
                Console.WriteLine($"Your operation is: {num1} * {num2}\r\n");
                answer = num1 * num2;
                break;
            case 4:
                Console.WriteLine($"You are dividing {num1} and {num2}\r\n");
                Console.WriteLine($"Your operation is: {num1} / {num2}\r\n");
                try
                {
                    answer = num1 / num2;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("CANNOT DIVIDE BY ZERO!\r\n");
                }
                break;
            case 5:
                for (int i = num1; i <= num2; i++)
                {
                    answer += i;
                }
                break;
            default:
                throw new Exception("Invalid Menu Item Selected.");
        }
        Console.WriteLine($"RESULT: {answer}");

        Console.WriteLine("\r\nDo you want to continue? (1 for yes / 2 for no)");
        calculatorRestart = Convert.ToInt32(Console.ReadLine());

        if (calculatorRestart == 2)
        {
            Console.WriteLine("\r\nYou are now exiting the calculator");
            Thread.Sleep(1500);
            Console.Clear();
            break;
        }
        else if (calculatorRestart != 1)
        {
            Console.Clear();
            Console.WriteLine("Invalid option. Try again!");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("\r\n" + ex.Message + "\r\nPLEASE TRY AGAIN!");
        Thread.Sleep(1500);
    }
}

Console.WriteLine("******** - Thank you for using the sample calculator! - ********");