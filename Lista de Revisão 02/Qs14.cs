using System; 

public class Program {
  public static void Main(string[] args) {
    
    Console.WriteLine("Digite três valores");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
            
    if (a < b + c && b < a + c && c < a + b)
    {
      if (a == b && a == c) Console.WriteLine("O triângulo é equilátero");
      else
      {
                    
      if (a == b || a == c || b == c)
      Console.WriteLine("O triângulo é isósceles");
                  
      else
      Console.WriteLine("O triângulo é escaleno");
      }
    }
      else
    {
      Console.WriteLine("Esses valores não formam um triângulo");

    }
  }
}