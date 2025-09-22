using System;

public class JogoCartas
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("=== Jogo de Cartaz ===");
        Random numero = new Random();
        int vermelho = 0;
        int preto = 0;
        int i = 1;
        while(i<=21){
            int carta = numero.Next(1,13);
            Console.WriteLine (carta);
            if(i%2 == 0){
                vermelho = vermelho + carta;
                
            } else{
                preto = preto + carta;
            }
            i++;
        }
        
        if (vermelho > preto){
            Console.WriteLine("Vermelho ganhou com "+vermelho+" pontos");
        } else if (vermelho < preto){
            Console.WriteLine("Preto ganhou com "+preto+" pontos!");
        } else{
            Console.WriteLine("Empate");
        }
    }
}