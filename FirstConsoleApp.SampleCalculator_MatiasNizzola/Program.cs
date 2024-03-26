/* SCHEMA

1. Welcome
2. Input
    1. num1
    2. Operation
        1. Addition
        2. Subtraction
        3. Multiplication
        4. Division
    3. num2
3. Action
4. Output
5. Farewell
 */

// Welcome message

Console.WriteLine("********** - WELCOME TO MY FIRST CODED CALCULATOR IN C# - **********");
Console.WriteLine("Please note this calc. works just for two numbers");

// Prompt user's input

// Ask for num1

Console.WriteLine("\r\nPlease enter the first number");
int num1 = Convert.ToInt32(Console.ReadLine());

// Calculation options

Console.WriteLine("\r\n********** - PLEASE SELECT AN OPERATION - **********");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division\r\n");

int operation = Convert.ToInt32(Console.ReadLine());

// Ask for num2

Console.WriteLine("\r\nPlease enter the second number");
int num2 = Convert.ToInt32(Console.ReadLine());

// Decide which operation is needed based on selected option:

int result = 0;

// VIA IF ... ELSE IF

//if (operation == 1)
//{
//    result = num1 + num2;
//    Console.WriteLine($"\r\nYou are adding {num1} and {num2}");
//}
//else if (operation == 2)
//{
//    result = num1 - num2;
//    Console.WriteLine($"\r\nYou are subtracting {num2} from {num1}");
//}
//else if (operation == 3)
//{
//    result = num1 * num2;
//    Console.WriteLine($"\r\nYou are multiplying {num1} and {num2}");
//    if (num1 == num2)
//    {
//        Console.WriteLine($"\r\nThat's to say, you are squaring {num1}");
//    }
//}
//else if (operation == 4)
//{
//    result = num1 / num2;
//    Console.WriteLine($"\r\nYou are dividing {num1} by {num2}");
//}
//else
//{
//    Console.WriteLine("\r\nThe selected value is not valid");
//}

// VIA SWITCH

switch (operation)
{
    case 1:
        result = num1 + num2;
        Console.WriteLine($"\r\nYou are adding {num1} and {num2}");
        break;
    case 2:
        result = num1 - num2;
        Console.WriteLine($"\r\nYou are subtracting {num2} from {num1}");
        break;
    case 3:
        result = num1 * num2;
        Console.WriteLine($"\r\nYou are multiplying {num1} and {num2}");
        break;
    case 4:
        result = num1 / num2;
        break;
    default:
        Console.WriteLine("\r\nThe selected value is not valid");
        break;
}


// Print out

Console.WriteLine($"\r\nThe result of your operation is:\r\n{result}");