using System;

public class EscolhaDia
{
    public static void Main(string[] args)
    {
    Console.WriteLine ("===Dia da Semana ===");
    Console.WriteLine ("Digite o dia da semana: ");
    int dia = Convert.ToInt32(Console.ReadLine());
    switch(dia){
    case 1: 
        Console.WriteLine ("Domingo");
        break;
    case 2: 
        Console.WriteLine ("Segunda-Feira");
        break;
    case 3: 
        Console.WriteLine ("Terça-Feira");
        break; 
    case 4: 
        Console.WriteLine ("Quarta-Feira");
        break;
    case 5: 
        Console.WriteLine ("Quinta-Feira");
        break;
    case 6: 
        Console.WriteLine ("Sexta-Feira");
        break;    
    case 7: 
        Console.WriteLine ("Sabado");
        break;
    default: 
        Console.WriteLine ("Dia invalido!");
        break;
    }
    
}
}