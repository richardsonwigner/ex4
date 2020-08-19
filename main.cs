using System;

public class Program{

    public static void Main () {
      float n1,n2,n3,n4,media;
     
    Console.Write("Nota 1>> ");
      n1 = int.Parse(Console.ReadLine());
    Console.Write("Nota 2>> ");
      n2 = int.Parse(Console.ReadLine());
      Console.Write("Nota 3>> ");
      n3 = int.Parse(Console.ReadLine());
    Console.Write("Nota 4>> ");
      n4 = int.Parse(Console.ReadLine());

       media = (n1+n2+n3+n4) / 4;

      
       

    Console.WriteLine("A nota do aluno é {0}",media);
  }
}