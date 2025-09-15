using System;
using System.Collections.Generic;

public class ListaAlunos
{
    public static void Main(string[] args)
    {
  List<string> alunos = new List<string>();
     alunos.Add("Zuleica");
     alunos.Add("Ana");
     alunos.Add("Abner");
     alunos.Add("Daniel");
     alunos.Add("Will");
      alunos.Sort();
     foreach (var aluno in alunos)
     {
       Console.WriteLine(aluno);
     }
}
}