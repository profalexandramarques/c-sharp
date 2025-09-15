using System;

public class ParImpar
{
    public static void Main(string[] args)
    {
       Console.WriteLine("=== Par ou impar ===");
       Console.WriteLine("Digite um valor:");
       double a = Convert.ToDouble(Console.ReadLine());
       if(a % 2 == 0){
           Console.WriteLine("Par!");
       } else{
           Console.WriteLine("Impar! ");
       }
    
    }
}