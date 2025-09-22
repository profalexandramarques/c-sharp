using System;
using System.Collections.Generic;

class Conta
{
  private string titular; // atributo
  public string Titular   // propriedade
  {
    get { return titular; }   // get method
    set { titular = value; }  // set method
  }
  
  private string tipo; // atributo
  public string Tipo   // propriedade
  {
    get { return tipo; }   // get method
    set { tipo = value; }  // set method
  }

  private int numero; //atributo
  public int Numero   // propriedade
  {
    get { return numero; }   // get method
    set { numero = value; }  // set method
  }

  private double saldo; //atributo
  public double Saldo   // propriedade
  {
    get { return saldo; }   // get method
    set { saldo = value; }  // set method
  }
  
  //Construtor da classe
  public Conta(){
      saldo = 0;
  }

  //Métodos  
  public void verSaldo(){
      Console.WriteLine("Saldo R$"+Math.Round(Saldo,2));
   }

  public void depositar(double valor){
      saldo = saldo + valor;
  }
  public void sacar (double valor){
      if((saldo - valor) >= 0) {
          saldo = saldo - valor;
      } else{
       Console.WriteLine("Saldo insuficiente!");   
      }
  }
   public void mostrar()
    {
        Console.WriteLine($"Titular: {Titular}, Numero: {Numero}, Saldo: {Saldo}");
    }
  
}

public class ContaBancaria
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("== ESP Bank ===");
        Conta conta = new Conta();
        conta.Titular = "Alexandra";
        conta.Numero = 12345;
        conta.mostrar();
        conta.depositar(100);
        conta.depositar(500);
        conta.depositar(70.99);
        conta.sacar(50);
        conta.verSaldo();
    }
}