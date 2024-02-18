// #1 DECLARE VARIABLES

// "string name;" --> Al declarar una variable sin asignarle valor se lo llama inicializar la variable
// No obstante vamos a inicializarla de una forma más limpia, asignandole un valor vacío:

string firstName = string.Empty;
string lastName = string.Empty;
int age  = 0; //Hay que evitar que no tengan un valor por defecto
int retirementAge = 65; //Por ejemplo en España

//NEW VARIABLES 18/02/2024

decimal salary = 0; // 0 es el valor defecto de decimal
char gender = char.MinValue; // char.MinValue es el valor defecto de char
bool working = false; // false es el valor defecto de boolean


/**************************************************************************************************/

// #2 PROMPT THE USER INPUT

// NAME

Console.WriteLine("Please enter your first name"); // Escribe la línea "Por favor introduce tu nombre". Es lo que se le pide al usuario

firstName = Console.ReadLine(); //Permitirá en la consola (recordemos que esto es una aplicación de consola) lectura (escritura del lado del usuario) de la línea que se espera que rellene. En este caso el nombre = lo que el usuario introduzca

Console.WriteLine("Please enter your last name");

lastName = Console.ReadLine();

// AGE

Console.WriteLine("Please enter your age");
age = Convert.ToInt32(Console.ReadLine()); // La función Console.ReadLine funciona para strings. Con una variable numérica como la edad tendremos que transformar el la función de manera que lea "Int" --> función Convert.(distintas opciones)

// SALARY

Console.WriteLine("How much do you earn? (salary)");

salary = Convert.ToInt32(Console.ReadLine()); //Luego veremos como Convert.ToDecimal

// GENDER

Console.WriteLine("Please enter your gender (please type M or F)");

gender = Convert.ToChar(Console.ReadLine());

// EMPLOYMENT STATUS

Console.WriteLine("Are you working right now? (please type true or false)");

working = Convert.ToBoolean(Console.ReadLine());

// #3 PROCESS THE DATA

// Declararemos edad de jubilación arriba

int workingYearsRemaining = retirementAge - age;

// #4 OUTPUT:

Console.WriteLine('\n'+ "USER'S INPUT:");

Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
Console.WriteLine($"Salary: {salary}");
Console.WriteLine($"Gender: {gender}");
Console.WriteLine($"Is working?: {working}");



