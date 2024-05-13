// See https://aka.ms/new-console-template for more information
using AreaOfCircle;

Console.WriteLine("Hello!  Please enter the radius of your circle.");
string input = Console.ReadLine();
double radius = double.Parse(input);
Circle circle = new(radius);


Console.WriteLine($"A circle with a radius of {radius}mi has an area of {circle.Area} square mi,");
Console.WriteLine($"a circumference of {circle.Circumference} mi,");
Console.WriteLine($"and a diameter of {circle.Diameter}mi.");

Console.WriteLine("\nNow let's figure out how much gas you need to get around a circle like that.");
Console.WriteLine("What is your car's mpg?");
string? mpgStr = Console.ReadLine();
double mpg = double.Parse(mpgStr);

double gallonsToCircumnavigate = circle.Circumference / mpg;
Console.WriteLine($"Your car will need {gallonsToCircumnavigate} gallons of gas to get around the circle.");
