using System; 

class Program {
  public static double Diagonal(double b, double h){
    double diagonal = Math.Sqrt(b * b + h * h);
    return diagonal;
}
  public static void Main(){
    Console.WriteLine("digite a base do retângulo");
    double b = double.Parse(Console.ReadLine());

    Console.WriteLine("digite a altura do retângulo");
    double h = double.Parse(Console.ReadLine());

    Console.WriteLine(Diagonal(b,h));
  }
}