using System;

public class Maior
{
    public static void Main(string[] args)
    {
       Console.WriteLine("=== Maior ===");
       Console.WriteLine("Digite um valor:");
       double a = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Digite outro valor:");
       double b = Convert.ToDouble(Console.ReadLine());
       if(a >= b){
           Console.WriteLine("a maior ou igual que b!");
       } else{
           Console.WriteLine("b maior que a! ");
       }
    }
}