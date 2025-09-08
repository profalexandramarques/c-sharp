using System;

public class Conversao
{
    public static void Main(string[] args)
    {
       Console.WriteLine ("Digite o seu nome: ");
       string nome = Console.ReadLine();
       Console.WriteLine ("Boa tarde "+nome+"!");
       Console.WriteLine ("Digite a sua idade: ");
       int idade = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine ("Digite a sua altura: ");
       float altura = Convert.ToSingle(Console.ReadLine());
       Console.WriteLine ("Digite o salário: ");
       double salario = Convert.ToDouble(Console.ReadLine());
    }
}