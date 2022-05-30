using System; 

public class Program {
  public static void Main(string[] args) {

    Console.WriteLine("Digite dois valores inteiros");
    String a = Console.ReadLine();
    int x = int.Parse(a);
    String b = Console.ReadLine();
    int y = int.Parse(b);

    if (x == y) Console.WriteLine("Números iguais");
    else
      if (x > y) Console.WriteLine("Maior = " + x);
      else
        if (x < y) Console.WriteLine("Maior = " + y);
  }
}   