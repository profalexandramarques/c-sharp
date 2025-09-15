using System;

public class AreaTriangulo
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Area do Circulo!");
        Console.WriteLine ("Digite a base: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine ("Digite a altura: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double area = (b*a)/2;
        Console.WriteLine ("Area "+Math.Round(area,2));
    }
}