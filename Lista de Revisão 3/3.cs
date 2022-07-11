using System; 

public class Program {
  public static void Main(string[] args) {
    
    int x = 1; 
    int y = 1;
    while (x <= 10) {
      Console.WriteLine(x * y);
      y = -y;
      x++;
    }
  }
}