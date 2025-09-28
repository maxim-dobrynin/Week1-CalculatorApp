Console.WriteLine("Type in the first number followed by the Enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type the second number, and then press Enter");
int secondNumber = Convert.ToInt32(Console.ReadLine());
// Perform calculation
int result = firstNumber + secondNumber;
// Output answer to console
Console.WriteLine("Adding {0} and {1} gives the answer {2}", firstNumber, secondNumber, result);