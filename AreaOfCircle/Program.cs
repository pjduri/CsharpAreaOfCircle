// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!  Please enter the radius of your circle.");
string input = Console.ReadLine();
double radius = double.Parse(input);
double pi = Math.PI;

double area = pi * Math.Pow(radius, 2);

Console.WriteLine($"A circle with a radius of {radius}cm has an area of {area} square cm,");