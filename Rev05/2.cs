using System; 

class Program {
  public static double AreaCirculo(double raio){
    
    double pi = 3.14159;
    double area = pi * raio * raio;
    return area;
  }
  public static void Main(){
    Console.WriteLine("Digite o valor do raio");
    double raio = double.Parse(Console.ReadLine());
    Console.WriteLine(AreaCirculo(raio));
  }
}