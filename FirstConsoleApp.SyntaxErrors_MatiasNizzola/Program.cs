// ERRORS & WARNINGS LESSON:

//SYNTAX ERRORS

// #1 Three dots under initialized variable:

using System.Runtime.InteropServices.Marshalling;

string? firstName = string.Empty; //Los 3 puntitos debajo de "firstName" nos indican la "agregación innecesaria de un valor a firstName". No es un error, pero se "solventaria" declarando la variable en lugar de inicializándola. Es un simple aviso de que "no necesitábamos llegar a inicializarla". Por ejemplo como con "lastName" abajo:

// #2 Green underline:

string lastName; //Esto es declarar una variable. Ahora lastName tiene debajo suya lineas onduladas que indican que se ha declarado pero no se está usando. Esto desaparecerá cuando se inicialice. (Más abajo)

Console.WriteLine("Please enter your last name");

lastName = Console.ReadLine(); //Ahora tenemos otro warning que indica que estamos ante un tipo de dato qué, de no darle un valor, podremos caer en que termine teniendo un valor NULL. string (al igual que otros tipos de datos) no puede tener valor NULL. Se limita a avisarnos

    //No obstante podemos tornar la variable nullable mediante insertar ? delante del tipo de dato en su declaración / inicialización (más arriba):

Console.WriteLine("Please enter your last name");

firstName = Console.ReadLine();

/* #3 Red underline:
      SCENARIO 1: "foolish" coding*/

strong /*en lugar de string*/ papitas = "fibdrgig";

//    SCENARIO 2: Incorrect coding

char gender;
Console.WriteLine("Please enter your gender (M or F)");
gender = Convert.ToBase64CharArray(Console.ReadLine()); // gender es un char y le estamos pidiendo una conversión a un tipo de dato distinto que es un Base64CharArray.

//    SCENARIO 3: Cannot implicitly convert a 'datatype' to a 'anotherdatatype'

decimal salary;

salary = Console.ReadLine(); // salary es un decimal y le estamos pidiendo al código el método ReadLine que sirve (de base) para string. El método necesitará transformar el tipo de dato antes de procesarlo finalmente:

salary = Convert.ToInt32(Console.ReadLine()); // esta es la conversión correcta


//    SCENARIO 4: Syntax errors:

salary = Convert.ToInt32(Console.ReadLine(); // estructuras faltantes, por ejemplo un paréntesis "Se esperaba )"
salary = Convert.ToInt32(Console.ReadLine()) // falta de cierre "Se esperaba ;"
salary = Convert.ToInt32(Console.Read Line()); // mala sintaxis en los métodos, como un espacio en un método (ReadLine; no Read Line)
 

/************************************************************************************************************************/


//LOGIC ERRORS (go to "FirstConsoleApp.LogicErrors_MatiasNizzola)