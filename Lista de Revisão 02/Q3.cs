using System; 

public class Program {
  public static void Main(string[] args) {

    Console.WriteLine("Digite quatro valores inteiros");
    int q = int.Parse(Console.ReadLine());
    int w = int.Parse(Console.ReadLine());
    int e = int.Parse(Console.ReadLine());
    int r = int.Parse(Console.ReadLine());
            
    int p = 0, i = 0;

    if (q % 2 == 0) p += q;
    else i += q;
    if (w % 2 == 0) p += w; else i += w;
    if (e % 2 == 0) p += e; else i += e;
    if (r % 2 == 0) p += r; else i += r;

    Console.WriteLine($"Soma dos pares = {p}");
    Console.WriteLine($"Soma dos ímpares = {i}");

  }
}