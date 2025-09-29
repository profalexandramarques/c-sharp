using System;

public class CaraouCoroa
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("=== Jogo Cara ou Coroa ===");
        var numero = new Random();
        Console.WriteLine("Escolha: \n1 - Cara ou \n2 - Coroa:");
        int moeda = Convert.ToInt32(Console.ReadLine());
        int jogada = numero.Next(1, 2); 
        string caracoroa = "Cara";
        if (jogada != 1){
            caracoroa = "Coroa";
        }
        
        if(moeda ==jogada){
            Console.WriteLine ($"Voce venceu {caracoroa}!");
            
        } else{
            Console.WriteLine ($"Tente outra vez {caracoroa}!");
        }
    }
}