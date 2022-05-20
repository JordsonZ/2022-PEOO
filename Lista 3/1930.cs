using System; 

public class Program {
  public static void Main(string[] args) {
    
    string[] entrada = Console.ReadLine().Split(' ');
    int.TryParse(entrada[0], out int t1);
    int.TryParse(entrada[1], out int t2);
    int.TryParse(entrada[2], out int t3);
    int.TryParse(entrada[3], out int t4);
    Console.WriteLine(t1 + t2 + t3 + t4 - 3);

  }
}