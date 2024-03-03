//LOGIC ERRORS:

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
decimal salary = 0;
char gender = char.MinValue;
bool working = false;

/**************************************************************************************************/

Console.WriteLine("Please enter your first name"); 
firstName = Console.ReadLine(); 

Console.WriteLine("Please enter your last name");
lastName = Console.ReadLine();

// 18/02/2024 20:15 creamos un "Breakpoint":

Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine()); 


Console.WriteLine("Please enter your salary");
salary = Convert.ToInt32(Console.ReadLine()); //No hay errores de sintaxis por lo que nos corre la aplicación.

//Peeeeero, una vez abierta, al pedirnos el salario incorporamos decimales (1412.54) al haberla declarado como "decimal salary". Lo que pasa que al compilador le hemos dicho que la lea convertida a Int32 en lugar de a decimal y eso desencadena:

/*Unhandled exception. System.FormatException: The input string '1412.54' was not in a correct format.
   at System.Number.ThrowFormatException[TChar](ReadOnlySpan`1 value)
   at System.Convert.ToInt32(String value)
   at Program.<Main>$(String[] args) in C:\Users\matia\Documents\Cursos\C#\FirstConsoleApp.Demos_MatiasNizzola\FirstConsoleApp.LogicErrors_MatiasNizzola\Program.cs:line 22*/

//Además nos dice en qué línea del código ocurre

//Para corregirlo, pondremos el tipo de dato esperado (creemos otra variable para tener todo en el código):

decimal salarycorrect;
Console.WriteLine("Please enter your salary");
salarycorrect = Convert.ToDecimal(Console.ReadLine()); //Ahora si escribimos 1412.54 nos lo dejará pasar

//Ahora veamos que pasa si en char gender el usuario escribe "Male" (string) en lugar de "M" (char) que es el esperado:

Console.WriteLine("Please enter your gender (M or F)");
gender = Convert.ToChar(Console.ReadLine());

/*Unhandled exception. System.FormatException: String must be exactly one character long.
   at System.Convert.ToChar(String value, IFormatProvider provider)
   at Program.<Main>$(String[] args) in C:\Users\matia\Documents\Cursos\C#\FirstConsoleApp.Demos_MatiasNizzola\FirstConsoleApp.LogicErrors_MatiasNizzola\Program.cs:line 42
 */

//Al meter "Male" nos indica que la cadena de texto debía ser de un caracter de largo, es decir, char y no hemos cumplido la condición


Console.WriteLine("Are you working right now? (true or false)");
working = Convert.ToBoolean(Console.ReadLine());


Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Salary: {salary}");
Console.WriteLine($"Gender: {gender}");
Console.WriteLine($"Is working: {working}");