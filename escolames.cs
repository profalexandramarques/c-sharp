using System;

public class EscolhaMes
{
    public static void Main(string[] args)
    {
    Console.WriteLine ("===Mes do Ano ===");
    Console.WriteLine ("Digite o mes: ");
    int mes = Convert.ToInt32(Console.ReadLine());
    switch(mes){
    case 9: 
        Console.WriteLine ("Setembro");
        break;
    case 10: 
        Console.WriteLine ("Outubro");
        break;
    case 11: 
        Console.WriteLine ("Novembro");
        break; 
    case 12: 
        Console.WriteLine ("Dezembro");
        break;
    }
    
}
}