using System; 

public class Program {
  public static void Main(string[] args) {
    
    string[] str = Console.ReadLine().Split(' ');
    int.TryParse(str[0], out int c);
    int.TryParse(str[1], out int p);
    
    Console.WriteLine(c % p);

  }
}