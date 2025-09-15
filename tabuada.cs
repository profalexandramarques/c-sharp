public class Tabuada
{
    public static void Main(string[] args)
    {
    
    Console.WriteLine ("Digite um numero: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("=== Tabuada "+numero+" ===");
    for (int i=0;i<=10;i++)
    {
     Console.WriteLine (numero + " X "+i + " = "+numero*i);
    }
}
}