using System; 

class Program {
  public static double Menor(double x, double y){

    if (x > y)
      return x;
      else
        return y;
  }

  public static void Main() {

    Console.WriteLine("Escreva o primeiro número");
    int x = int.Parse(Console.ReadLine());

    Console.WriteLine("Escreva o segundo número");
    int y = int.Parse(Console.ReadLine());

    Console.WriteLine(Menor(x,y));

  }
}