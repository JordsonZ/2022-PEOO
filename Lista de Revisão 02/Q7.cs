using System; 

public class Program {
  public static void Main(string[] args) {

    Console.WriteLine("Digite os coeficientes a, b, e c de uma equação do II grau");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
            
    if (a == 0)
    Console.WriteLine("A equação não é do II grau");
    else
      {
            
      double delta = b * b - 4 * a * c;
                
      if (delta < 0)
      Console.WriteLine("Impossível calcular, a equação não tem raízes reais");
      else
      {
                    
        double x1 = (-b + Math.Sqrt(delta)) / 2 / a;
        double x2 = (-b - Math.Sqrt(delta)) / 2 / a;
        Console.WriteLine($"As raízes são {x1} e {x2}");
                  
      }  
    }
  }
}