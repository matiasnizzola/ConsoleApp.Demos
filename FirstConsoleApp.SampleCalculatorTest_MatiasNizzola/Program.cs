/* SCHEMA

1. Welcome
2. Input
    1. Operation
        1. Addition
        2. Subtraction
        3. Multiplication
        4. Division
        5. Fibonacci sequence
    2. num1
    3. num2
3. Action
4. Output
5. Farewell
 */

// Welcome message

Console.WriteLine("********** - WELCOME TO MY FIRST CODED CONSOLE APP CALCULATOR IN C# - **********");
Console.WriteLine("Please note this calc. works just for two numbers\r\n");

// Variable declarations

int operation = 0;
int num1, num2 = 0;
int result = 0;
int calculatorWannaRestart = 0;

// PROMPT USER'S INPUT

// Operation

while (operation != -1)
{
    try
    {
        {
            Console.WriteLine("PLEASE SELECT AN OPERATION (1 TO 4). ENTER '-1' TO EXIT THE CALCULATOR");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division\r\n");

            operation = Convert.ToInt32(Console.ReadLine());

            if (operation < 1 || operation > 4)
            {
                Console.Clear();
                Console.Write("The option is not available. Please try again");
                break;
            }

            Console.Clear();

            // Values

            // NUM1

            Console.WriteLine("Please insert the first number\r\n");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            // NUM2

            Console.WriteLine("Please insert the second number\r\n");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            // OPERATION

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"You are making {num1} + {num2}\r\n");
                    result = num1 + num2;
                    break;
                case 2:
                    Console.WriteLine($"You are making {num1} - {num2}\r\n");
                    result = num1 - num2;
                    break;
                case 3:
                    Console.WriteLine($"You are making {num1} * {num2}\r\n");
                    result = num1 * num2;
                    break;
                case 4:
                    Console.WriteLine($"You are making {num1} / {num2}\r\n");
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("The selected operation is not valid. Please try again");
                    break;
            }

            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Do you want to continue? (1 for yes / 2 for no)\r\n");

            calculatorWannaRestart = Convert.ToInt32(Console.ReadLine());

            switch (calculatorWannaRestart)
            {
                case 1:
                    Console.Clear();
                    continue;
                case 2:
                    Console.Clear();
                    Console.WriteLine("You are now exiting the calculator!");
                    break;
            }
        }
    }
    catch (Exception)
    {
        Console.WriteLine("The entered value was not valid. Try again");
        continue;
    }
}

/***********************************************************************************/

//ENDING MESSAGE

Console.Clear();
Console.WriteLine("You are now exiting the calculator!\r\n");
Console.WriteLine("THANKS FOR USING! GOODBYE!");




