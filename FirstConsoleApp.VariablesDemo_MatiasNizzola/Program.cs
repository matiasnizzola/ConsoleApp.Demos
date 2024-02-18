// See https://aka.ms/new-console-template for more information

// DATA TYPES & VARIABLES
/*
        text - string
        integers - int
        decimal - double, float, decimal (difieren en la precisión)
        logical - bool (true, false)
 */

// Para evitar la repetición de código (entre otras funciones) creamos las variables:
/*NORMAS DE LAS VARIABLES:
    * No puede usarse espacios en el nombre
    * Caracteres especiales (salvo _)

/*   STRING

 * Por ejemplo, si tengo tres líneas de código para mi nombre
    Console.WriteLine("Soy Matías Nizzola");
    Console.WriteLine("Me llaman Matías Nizzola");
    Console.WriteLine("Fui dado el nombre de Matías Nizzola");

Vemos que se repite mi nombre, por lo que declararemos la variable "nombre":*/

string name = "Matías Nizzola";

// Ahora en lugar de tener que escribir constantemente mi nombre, bastará usarlo:

Console.WriteLine(name);

//MÉTODOS DE COMBINACIÓN DE PARTES ESTÁTICAS CON VARIABLES

//Ahora veamos "concatenación de texto": combinar una variable y una porción de texto "estática" (string concatenation)
Console.WriteLine("Soy " + name);

//ahora "interpolación": superposición de la variable en la cadena estática (string interpolation)
Console.WriteLine($"Me llaman {name}");

//Cadena formateada (formatted string)
Console.WriteLine("Me llaman {0}", name);

//  INTEGERS

int age = 54;
int my_Age = 54; //Recordar que hay distinción entre mayús y minus por lo que son dos variables
int my_age = 54;

Console.WriteLine("My age is: " + age);

//Escenario 2: calcular una variable acorde a otras declaradas, como la edad de jubilación según la edad actual y los años que faltan para jubilarme

int retirementYearsLeft = 11;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine(retirementAge);
Console.WriteLine("Me podré jubilar a los " + retirementAge);

//ahora veamos que pasa si quisiera declarar "retirementAgeLeft" como un string en lugar de int:

//string retirementAgeLeft2 = age + retirementYearsLeft;

// Devuelve "Cannot implicitly convert type 'int' to 'string'" porque el valor de la operación es un int y no un string


// BOOLEAN: expresan dicotomía true / false

bool isRetired = true;