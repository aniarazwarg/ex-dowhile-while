using System;

class Program {
  public static void Main (string[] args) {
     int cont=0, num=0;
    
    Console.WriteLine("FOR");
    for(int i=0;i<=5;i++)
      Console.WriteLine("{0}- valor1", i);

    Console.WriteLine("");
    Console.WriteLine("Faça Enquanto");
    //pizzaria Faça.....Enquanto
    do
    {
      Console.WriteLine("{0}- valor1", cont);
      cont++;
    }while(cont<=5); //Volta quando for verdade
    
    Console.WriteLine("");
    Console.WriteLine("Enquanto");
    //McDonalts Enquanto....FimEnquanto
    while(num<=5) //Entra quando for verdade
    {
      Console.WriteLine("{0}- valor2", num);
      num++;
    }
  }
}