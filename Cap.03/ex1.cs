using System;

class Program {
  public static void Main () {
    Console.WriteLine("digite o seu peso:");
    double p = double.Parse(Console.ReadLine());
    Console.WriteLine("digite a sua altura:");
    double a = double.Parse(Console.ReadLine());
    IMC x = new IMC();
    x.SetPeso(p);
    x.SetAltura(a);
    Console.WriteLine("Seu IMC será = " + x.CalcIMC());
  }
}

class IMC{
  private double x;
  private double y;
  public void SetPeso(double r){
    if (r > 0)
      x = r;
  }
  public void SetAltura(double r){
    if (r > 0)
      y = r;
  }
  public double GetPeso(){
    return x;
  }
  public double GetAltura(){
    return y;
  }
  public double CalcIMC(){

    double IMC = x / (y*y);
    return IMC;
  } 
}