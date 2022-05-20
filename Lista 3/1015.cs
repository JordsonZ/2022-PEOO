using System; 

public class Program {
  public static void Main(string[] args) {
    
    double x1, x2, y1, y2;
    string[] line1 = Console.ReadLine().Split(' ');
    string[] line2 = Console.ReadLine().Split(' ');

    x1 = double.Parse(line1[0]);
    x2 = double.Parse(line2[0]);
    y1 = double.Parse(line1[1]);
    y2 = double.Parse(line2[1]);

    Console.WriteLine("{0:f4}",Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
  }
}