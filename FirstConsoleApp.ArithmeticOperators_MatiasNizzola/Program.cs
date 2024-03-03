//OPERATORS

/* ARITHMETIC OPERATORS: help us to complete math operations

+ --> addition (suma)
- --> subtraction (resta)
* --> multiplication (multiplicación)
/ --> division (división)
% --> modulus

They follow the BOMDAS rules (regla de orden de operaciones)

B: Brackets --> ()
O: Order --> higher operations or operators go before lower ones (square of a number before an addition): 3^2 + 4 = 9 + 4 = 13
M: Multiplication
                        Either multiplication or division are at the same level of ordinance and go before addition or subtraction
D: Division
A: Addition
S: Subtraction

 */


Console.WriteLine("Welcome to the basic C# calculator!");

Console.WriteLine("Please enter your first number: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your second number: ");

int num2 = Convert.ToInt32(Console.ReadLine());

// ADDITION
int sum1 = num1 + num2;

// SUBTRACTION
int dif1 = num1 - num2;

// MULTIPLICATION
int prod1 = num1 * num2;

// DIVISION
int quo1 = num1 / num2;

//MODULUS
int mod1 = num1 % num2;

Console.WriteLine('\n' + "**** MATH OPERATORS RESULTS ****" + '\n');

Console.WriteLine($"Sum: {sum1}");
Console.WriteLine($"Difference: {dif1}");
Console.WriteLine($"Product: {prod1}");
Console.WriteLine($"Quotient: {quo1}");
Console.WriteLine($"Modulus: {mod1}");

/***********************************************************************************************************************************/

/* LOGIC OPERATORS: help us to compare values and return a boolean as a result

> --> greater than
< --> less than
== --> equivalent to: the logic is that this operator replies with a boolean to the question "is 'a' equivalent to 'b'?"
        '=' is for assignment & '==' logic for comparission
>= --> greater than or equal to
<= --> less than or equal to
!= --> not equal to

(for later)
|| --> OR
&& --> AND
 */

var isGreaterThan = 23 > 45;
var isLessThan = 23 < 45;
var isEquivalentTo = 23 == 45;
var isGreaterThanOrEqualTo = 23 >= 45;
var isLessThanOrEqualTo = 23 <= 45;
var isNotEqualTo = 23 != 45;

Console.WriteLine('\n' + "**** LOGIC OPERATORS RESULTS ****" + '\n');

Console.WriteLine($"isGreaterThan: {isGreaterThan}");
Console.WriteLine($"isLessThan: {isLessThan}");
Console.WriteLine($"isEquivalentTo: {isEquivalentTo}");
Console.WriteLine($"isGreaterThanOrEqualTo: {isGreaterThanOrEqualTo}");
Console.WriteLine($"isLessThanOrEqualTo: {isLessThanOrEqualTo}");
Console.WriteLine($"isNotEqualTo: {isNotEqualTo}");



/***********************************************************************************************************************************/

/* ASSIGNMENT OPERATORS: help us to assign values to a variable

= --> is equal to
+= --> increasing a variable
-= --> decreasing a variable
*= --> multiply a variable by
/= --> divide a variable by


Examples:

- Assign a value to a variable either:
    * Via variable -->  var num = 1;
    * Via data type --> int num = 1; / string name = "Albert";

- Reduce lines of code for calculations:
    * If wanting to sum 2 to the num1:
        * Instead of using num1 = num1 + 2, we can use num 1 += 2 --> so that the particle += means you are adding whatever after the = sign to whatever value or variable before the + sign
 */

Console.WriteLine('\n' + "**** ASSIGNMENT OPERATORS RESULTS ****" + '\n');

Console.WriteLine("CHANGING A SAME VARIABLE VALUE WITH THE ASSIGNMENT OPERATORS:" + '\n');

num1 = 45; // I'm changing num1 whatever value the user has inserted before to 45
Console.WriteLine($"num1 is NOW = {num1}");  //Should return 45 (reassignment to 45)
num1 += 45;
Console.WriteLine($"num1 + 45 is NOW = {num1}"); //Should return 90 (45 + 45 = 90)
num1 -= 45;
Console.WriteLine($"num1 - 45 is NOW = {num1}"); //Should return 45 (90 - 45 = 45)
num1 *= 45;
Console.WriteLine($"num1 * 45 is NOW = {num1}"); //Should return 2025 (45 * 45 = 2025)
num1 /= 45;
Console.WriteLine($"num1 / 45 is NOW = {num1}"); //Should return 45 (2025 / 45 = 45)

//CREATING A NEW VARIABLE FROM AN EXISTING ONE WITH THE ASSIGNMENT OPERATORS:

num2 = num1 + 2; // num2 = 45 + 2 --> 47
num2 += 36;
num2 -= 27;
num2 *= 2;
num2 /= 3;

