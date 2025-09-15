using System;

public class Voto
{
    public static void Main(string[] args)
    {
       Console.WriteLine ("Votar");
       Console.WriteLine("Digite a sua idade:");
       int idade = Convert.ToInt32(Console.ReadLine());
       if(idade >=16){
           Console.WriteLine("Pode votar!");
       } else{
           Console.WriteLine("Nao pode votar! ");
       }
       
       if (idade >=18){
           Console.WriteLine("CNH!");
       } else{
           Console.WriteLine("Nao CNH!");
       }
 
}
}