
using System;

public class Calculadora
{
    public static void Main(string[] args)
    {
      Console.WriteLine ("=== Calculadora ===");
      Console.WriteLine ("Digite a operacao: (+, -, /, *)");
      string op = Console.ReadLine();
            Console.WriteLine ("Digite um numero: ");
      double n1 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine ("Digite outro numero: ");
      double n2 = Convert.ToDouble(Console.ReadLine());
      double resultado = 0;
      if (op == "+"){
          resultado = n1+n2;
          Console.WriteLine ("A soma eh "+resultado);
      }else if (op == "-") {
          resultado = n1-n2;
           Console.WriteLine ("A subtracao eh "+resultado);
      }else if (op == "*") {
          resultado = n1*n2;
           Console.WriteLine ("A multiplicacao eh "+resultado);
      } else if (op == "/") {
          resultado = n1/n2;
           Console.WriteLine ("A divisao eh "+resultado);
      }
    }
}