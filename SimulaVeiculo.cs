using System;
using System.Collections.Generic;

class Veiculo
{
  private string placa; // atributo
  public string Placa   // propriedade
  {
    get { return placa; }   // get method
    set { placa = value; }  // set method
  }
  
  private string cor; // atributo
  public string Cor   // propriedade
  {
    get { return cor; }   // get method
    set { cor = value; }  // set method
  }
  private bool ligado;
  private int ano; //atributo
  public int Ano   // propriedade
  {
    get { return ano; }   // get method
    set { ano = value; }  // set method
  }
  private string marca;
  public string Marca   // propriedade
  {
    get { return marca; }   // get method
    set { marca = value; }  // set method
  }
  private string modelo;
  public string Modelo   // propriedade
  {
    get { return modelo; }   // get method
    set { modelo = value; }  // set method
  }
  //Construtor da classe
  public Veiculo(){
      ligado = false;
  }
  //Métodos
  public void ligar(){
      ligado = true;
      Console.WriteLine ("Veiculo ligado!");
  }
  public void desligar(){
      ligado = false;
      Console.WriteLine ("Veiculo desligado!");
  }
  
  //Mostrar os dados do veiculo
  public void mostrar()
    {
     Console.WriteLine($"Placa: {Placa}, Cor: {Cor}, Ano: {Ano}, \nMarca {Marca},Modelo: {Modelo}");
    }
}

public class SimulaVeiculo
{
    public static void Main(string[] args)
    {
      Console.WriteLine ("=== Simula Veiculo ===");
      //Cria uma lista de Veiculos
      List<Veiculo> listaVeiculos = new List<Veiculo>();
      //Criação do objeto
      Veiculo carro = new Veiculo();
      carro.Placa = "ABC1234";
      carro.Cor = "Prata";
      carro.Ano = 2000;
      carro.Modelo = "Corsa";
      carro.Marca = "Chevrolet";
      listaVeiculos.Add(carro);
      carro.ligar();
      
      //Adicionar segundo veiculo
      Veiculo fusca = new Veiculo();
      fusca.Placa = "XYZ7789";
      fusca.Ano = 1977;
      fusca.Cor = "Azul";
      fusca.Modelo = "Fusca";
      fusca.Marca = "Volkswagen";
      listaVeiculos.Add(fusca);
      fusca.ligar();
      //Mostra todos os veiculos da lista
      foreach (var veiculo in listaVeiculos)
      {
        veiculo.mostrar();
      }
      
    }
}