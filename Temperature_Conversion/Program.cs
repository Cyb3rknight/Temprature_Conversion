// Prompt the user to enter the temperature in degrees Celsius
Console.WriteLine("Degré Celsius : "); 

// Read the user's input and parse it as an integer
int Celsius = int.Parse(Console.ReadLine()) ;

// Calculate the temperature in degrees Fahrenheit using the formula:
// Fahrenheit = (Celsius * 9/5) + 32
// Then, use string interpolation to display the result, appending the "°F" symbol
Console.WriteLine($"Degré Fahrenheit : {(Celsius * 9/5)+32 }°F");