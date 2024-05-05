//LOOPS

//FOR LOOP

// Simple For Loop Demo
// Print Hello World 10 time

// 0 1 2 3 4 5 6 7 8 9
//for (int i = 0; i <10; i++ ) // "i" as per incrementer
//{
//    Console.WriteLine($"Hello, World! {i}");
//}

//Console.WriteLine("Loop finished!");

//  Ask user how many times they wish to print it and do so

Console.WriteLine("You are about to print a line several times. How many times do you want to do so?");
int count = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i > count; i++)
{
    Console.WriteLine($"{i} Hello, World!");
}

// WHILE LOOP

//Console.WriteLine("********** - WHILE LOOP - **********");

//int countWhile = 0;

//while (countWhile < 10)
//{
//    Console.WriteLine($"Hello, World! {counterwhile}");
//    countWhile += 2;
//}

