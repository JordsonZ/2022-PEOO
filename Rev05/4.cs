using System; 

class Program {
  public static double VolumeEsfera(double r){
    double pi = 3.14159;
    double volume = (4.0 / 3.0) * pi * r * r * r;
    return volume;
  }
  public static void Main(){
    Console.WriteLine("digite o raio da esfera");
    double r = double.Parse(Console.ReadLine());

    Console.WriteLine(VolumeEsfera(r));
  }
}