using System;

public class Boletim
{
    public static void Main(string[] args)
    {
    Console.WriteLine ("===Boletim ===");
    Console.WriteLine ("Digite a nota 1: ");
    double n1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Digite a nota 2: ");
    double n2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Digite a nota 3: ");
    double n3 = Convert.ToDouble(Console.ReadLine());    
    double media = (n1+n2+n3)/3;
    Console.WriteLine ("Media eh "+Math.Round(media,1));
    if(media >= 7){
        Console.WriteLine ("Aprovado");
    } else if(media >=6) {
        Console.WriteLine ("Exame");
    } else{
        Console.WriteLine ("Reprovado");
    }
    }
    
}