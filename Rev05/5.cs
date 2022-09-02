using System; 

class Program {
  public static double VolumeLitros(double h, double l, double p){
    double volume = h * l * p;
    return volume;
  
  }

  public static void Main(){
    Console.WriteLine("digite a altura");
    double h = double.Parse(Console.ReadLine());

    Console.WriteLine("digite a largura");
    double l = double.Parse(Console.ReadLine());

    Console.WriteLine("digite a profundidade");
    double p = double.Parse(Console.ReadLine());

    Console.WriteLine(VolumeLitros(h,l,p) + " litros");
  }
}