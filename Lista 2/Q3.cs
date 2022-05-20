using System; 

public class Program {
  public static void Main(string[] args) {

    Console.WriteLine("Digite a nota do primeiro bimestre da displina:");
    string a = Console.ReadLine();
    int h = int.Parse(a);

    Console.WriteLine("Digite a nota do segundo bimestre da displina:");
    string b = Console.ReadLine();
    int k = int.Parse(b);

    int j = ((h*2) + (k*3))/5;
    Console.WriteLine("Média parcial = " + j);

    }
}