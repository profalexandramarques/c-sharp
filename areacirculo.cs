using System;

public class AreaCirculo
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Area do Circulo!");
        double raio = 5;
        const double PI = 3.1415;
        double area = PI * (raio * raio);
        Console.WriteLine ("Area "+area);
    }
}