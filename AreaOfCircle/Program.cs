// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!  Please enter the radius of your circle.");
string input = Console.ReadLine();
double radius = double.Parse(input);
double pi = Math.PI;

double area = pi * Math.Pow(radius, 2);
double circumference = 2 * radius * pi;
double diameter = 2 * radius;

Console.WriteLine($"A circle with a radius of {radius}mi has an area of {area} square mi,");
Console.WriteLine($"a circumference of {circumference} mi,");
Console.WriteLine($"and a diameter of {diameter}mi.");

Console.WriteLine("\nNow let's figure out how much gas you need to get around a circle like that.");
Console.WriteLine("What is your car's mpg?");
string? mpgStr = Console.ReadLine();
double mpg = double.Parse(mpgStr);

double gallonsToCircumnavigate = circumference / mpg;
Console.WriteLine($"Your car will need {gallonsToCircumnavigate} gallons of gas to get around the circle.");
