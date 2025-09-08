using System;

public class CalcularIdade
{
    public static void Main(string[] args)
    {
       int anoAtual = 2025;
       Console.WriteLine ("Digite o seu nome: ");
       string nome = Console.ReadLine();
       Console.WriteLine ("Digite o ano do seu nascimento");
       int anoNasc = Convert.ToInt32(Console.ReadLine());
       int idade = anoAtual - anoNasc;
       Console.WriteLine ("A sua idade em "+anoAtual + " eh "+idade+" anos.");

    }
}