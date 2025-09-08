using System;

public class Soma
{
    public static void Main(string[] args)
    {
       Console.WriteLine ("Digite um numero: ");
       double a = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine ("Digite outro numero: ");
      double b = Convert.ToDouble(Console.ReadLine());
      double soma = a + b;
      Console.WriteLine ("A soma eh "+soma);
    }
}