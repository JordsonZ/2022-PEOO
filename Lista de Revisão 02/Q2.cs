using System; 

public class Program {
  public static void Main(string[] args) {

    Console.WriteLine("Digite quatro valores inteiros");
    String a = Console.ReadLine();
    int x = int.Parse(a);
    String b = Console.ReadLine();
    int y = int.Parse(b);
    String k = Console.ReadLine();
    int l = int.Parse(k);
    String m = Console.ReadLine();
    int n = int.Parse(m);

    int z = (n + m + l + b)/4;
      
    Console.WriteLine("Média = " + z);

    Console.WriteLine("Números menores que a média");
    
    if (z > n) Console.WriteLine(x);
    if (z > m) Console.WriteLine(y);
    if (z > l) Console.WriteLine(l);
    if (z > b) Console.WriteLine(n);

    Console.WriteLine("Números maiores ou iguais à média");
    
    if (z == n || z < n) Console.WriteLine(x);
    if (z == m || z < m) Console.WriteLine(y);
    if (z == l || z < l) Console.WriteLine(l);
    if (z == b || z < b) Console.WriteLine(n);
 
  }
}   