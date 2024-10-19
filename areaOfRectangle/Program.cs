// See https://aka.ms/new-console-template for more information

// Prompt the user for the length of the rectangle
Console.WriteLine("Enter the length a the rectangle: ");

// Store the user's response
double length = Convert.ToDouble(Console.ReadLine());

// Prompt the user for the width of the rectangle
Console.WriteLine("Enter the width a the rectangle: ");

// Store the user's response
double width = Convert.ToDouble(Console.ReadLine());

// Calculate the area of the rectangle
double area = length * width;

// Print the result using concatenation
Console.WriteLine("The area of the rectangle with the length of " + length + " and the width of " + width +  " is: " + area);
