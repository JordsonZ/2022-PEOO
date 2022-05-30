using System; 

public class Program {
  public static void Main(string[] args) {

    Console.WriteLine("Digite quatro valores inteiros diferentes");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
          
    if (a == b || a == c || a == d || b == c || b == d || c == d)
    Console.WriteLine("Algum número está repetido");
    else
      {
              
        int x = a;
        if (b < x) x = b;
        if (c < x) x = c;
        if (d < x) x = d;
                
        int y = a;
        if (b > y) y = b;
        if (c > y) y = c;
        if (d > y) y = d;
                
        int s = a + b + c + d - x - y;
        Console.WriteLine($"Maior valor = {y}");
        Console.WriteLine($"Menor valor = {x}");
        Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {s}");
        }
  }
}