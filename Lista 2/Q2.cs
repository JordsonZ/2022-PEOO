using System; 

public class Program {
  public static void Main(string[] args) {

    Console.WriteLine("Digite seu nome completo: ");
    string a = Console.ReadLine();
    string[] b = a.Split(" ");
      
    Console.WriteLine("Bem vindo ao C#, " + b[0]);

  }
}