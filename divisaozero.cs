using System;

public class DivisaoZero
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("=== Tratamento de Excecao ===");
        int numerador = 100;
        int divisor = 0; 
        try 
        {
           double divisao = numerador / divisor;
        }
        catch (Exception  e)
       {
          Console.WriteLine(e.Message);
       }
       finally{
           Console.WriteLine("O bloco 'finally' foi executado. O programa sera encerrado de forma segura.");
        }
       }
    
}