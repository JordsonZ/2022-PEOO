using System;

class Program {
  public static void Main () {
    Console.WriteLine("digite o raio do circulo:");
    double p = double.Parse(Console.ReadLine());
    Circulo x = new Circulo();
    x.SetRaio(p);
    Console.WriteLine("A area será = " + x.CalcArea());
    Console.WriteLine("A circuferencia será = " + x.CalcCircuferencia());
  }
}

class Circulo{
  private double x;
  public void SetRaio(double r){
    if (r > 0)
      x = r;
  }
  public double GetRaio(){
    return x;
  }
  public double CalcArea(){
    double pi = 3.14;

    double area = pi * x * x;
    return area;
  }
  public double CalcCircuferencia(){
    double pi = 3.14;

    double circuferencia = 2 * pi * x;
    return circuferencia;
  }   
}