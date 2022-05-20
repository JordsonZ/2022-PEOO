using System; 

public class Program {
  public static void Main(string[] args) {

    Console.WriteLine("Digite a base do retângulo:");
    string b = Console.ReadLine();
    double j = double.Parse(b);
    Console.WriteLine("Digita a altura do retângulo:");
    string h = Console.ReadLine();
    double l = double.Parse(h);

    double m = j*l;
    Console.WriteLine($"Área = {m:f2}");

    double k = 2*(j+l);
    Console.WriteLine($"Perímetro = {k:f2}");

    double a = Math.Sqrt(Math.Pow(j,2) + Math.Pow(l,2));
    Console.WriteLine($"Diagonal = {a:f2}");

  }
}