//SIMPLE IF / ELSE STATEMENT

using System.Security.Cryptography.X509Certificates;

Console.WriteLine("WELCOME TO THE GRADE CHECKER");

//PROMPT FOR INPUT

Console.WriteLine("Please enter the student's grade (from 0 to 100):");
Console.WriteLine("REMEMBER THE GRADINGS:\r\nA - Excellent: 85 - 100\r\nB - Very good: 75 - 84\r\nC - Good: 65 - 74\r\nD - Sufficient: 50 - 64\r\nE - High insufficient: 26 - 49\r\nF - Low insufficient / Fail: 0 - 25\r\n");

int grade = Convert.ToInt32(Console.ReadLine());

/* Decisions:
   Pass or Fail according to the student's grade
 */

/*
if (grade > 50)
{
    Console.WriteLine("PASS");
}
else
{
    Console.WriteLine("FAILED");
}
*/

// COMPLEX IF / ELSE IF STATEMENTS

/*
 Gradings
A - Excellent: 85 - 100
B - Very good: 75 - 84
C - Good: 65 - 74
D - Sufficient: 50 - 64
E - High insufficient: 26 - 49
F - Low insufficient / Fail: 0 - 25
 */

if (grade >= 0 && grade <= 25)
{
    Console.WriteLine("FAILED - F: Low insufficient");
}
else if (grade >= 26 && grade <= 49)
{
    Console.WriteLine("FAILED - E: High insufficient");
}
else if (grade >= 50 && grade <= 64)
{
    Console.WriteLine("PASSED - D: Sufficient");
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("PASSED - C: Good");
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("PASSED - B: Very good");
}
else if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("PASSED - A: Excellent");
}
else if (grade < 0 || grade > 100)
{
    Console.WriteLine("The entered value is out of boundaries (please type a value between 0 and 100)");
}


// TERNARY OPERATORS

// One-line code that returns a result or another based on a True or False condition

//Structure dataType + variableName = variable + operator + value ? "valueIfTrue" : "valueIfFalse"

Console.WriteLine("Now insert grade 2");

string gradeStatus = grade < 50 ? "Fail" : "Pass";

Console.WriteLine(gradeStatus);


//SWITCH STATEMENTS

/*

As the name says the result switches according to the condition of the case

1 - Sunday
2 - Monday
3 - Tuesday
4 - Wednesday
5 - Thursday
6 - Friday
7 - Saturday
*/

Console.WriteLine("What day of the week is today?");

int DayOfTheWeek = Convert.ToInt32(Console.ReadLine());

switch (DayOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Saturday");
        break;
    default:
        Console.WriteLine("Invalid day number entered. Please enter a value between 1 & 7");
        break;
}

Console.WriteLine("\r\nTHANK YOU FOR USING!");

/* SCOPE OF A VARIABLE
 * All variables must be declared before using them
 * Each {} is a block of code inside of which variables can be defined & declared but do not exist outside the block.
 * Basically, they set the context where the variable is working
 * 
 * FOR EXAMPLE:
 */

// Global scope: a variable defined at file level (that's to say, outside of any structure). It can be used anywhere. For instance:

int gradeOfStudent1 = 24;

if (gradeOfStudent1 > 24)
{
    Console.WriteLine($"Your grade does not correspond{gradeOfStudent1}");
}

// Specific scope: The variable is declared and use in a particular context and when attempted to be used outside of it, an error is returned

if (gradeOfStudent1 < 0)
{
    int gradeOfStudent2 = Convert.ToInt32(Console.ReadLine());
}
else
{
    Console.WriteLine($"Your grade does not correspond{gradeOfStudent2}");
}

Console.WriteLine($"Your grade does not correspond{gradeOfStudent2}");