using StaticExercise;
Console.WriteLine("----------------------------------------------------------");

Console.WriteLine("Enter a temperature in Farenheit to convert: ");
double userInput = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{userInput} converted from Fahrenheit to Celsius is: {Math.Round(TempConvert.FahrenheitToCelsius(userInput), 2)}°");

Console.WriteLine("----------------------------------------------------------");

Console.WriteLine("Enter a temperature in Celsius to convert: ");
double userInput2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{userInput2} converted from Celsius to Fahrenheit is: {Math.Round(TempConvert.CelsiusToFahrenheit(userInput2), 2)}°");

Console.WriteLine("----------------------------------------------------------");