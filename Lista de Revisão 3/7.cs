using System; 

public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite uma frase");
      string s = Console.ReadLine();
      Console.WriteLine(s);
      int p = s.IndexOf(' ');
      while (p != -1) {
      s = s.Substring(p + 1);
      Console.WriteLine(s);
      p = s.IndexOf(' ');
    }
  }
}