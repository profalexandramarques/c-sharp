using System;
using System.Collections.Generic;

class Jogador
{
  private string cor; // atributo
  public string Cor   // propriedade
  {
    get { return cor; }   // get method
    set { cor = value; }  // set method
  }
  
  private int pontos; //atributo
  public int Pontos   // propriedade
  {
    get { return pontos; }   // get method
    set { pontos = value; }  // set method
  }
 
  //Construtor da classe
  public Jogador(string cor){
      Cor = cor;
      pontos = 0;
  }
  //Métodos
  public void pontuar(int carta){
      pontos = pontos + carta;
  }

  //Mostrar os dados do jogador
  public void mostrar()
    {
     Console.WriteLine($"Cor: {Cor}, Pontos: {Pontos}!");
    }
}

public class JogoCartas
{
    public static void Main(string[] args)
    {
      Console.WriteLine ("=== Jogo 21 ===");
      Random numero = new Random();
      Jogador vermelho = new Jogador("Vermelho");
      Jogador preto = new Jogador("Preto");
      int i = 1;
       while(i<=21){
        int carta = numero.Next(1,13);
        //Console.WriteLine (carta);
        if(i%2 == 0){
            vermelho.pontuar(carta);
        } else{
            preto.pontuar(carta);
        }
        i++;    
       }
      Console.WriteLine ("=== Placar ==="); 
      vermelho.mostrar();
      preto.mostrar();
      //Verificar quem ganhou
      if (vermelho.Pontos > preto.Pontos){
            Console.WriteLine("Vermelho ganhou com "+vermelho.Pontos+" pontos");
        } else if (vermelho.Pontos < preto.Pontos){
            Console.WriteLine("Preto ganhou com "+preto.Pontos+" pontos!");
        } else{
            Console.WriteLine("Empate");
        }
    }
}