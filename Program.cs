// See https://aka.ms/new-console-template for more information
try
{
    Console.Write("Enter side A: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter side B: ");
    double b = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("The hypotenuse is: " + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
}
catch (Exception)
{
    Console.WriteLine("Not valid input");
}

