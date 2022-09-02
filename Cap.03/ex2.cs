using System;

class Program {
  public static void Main () {
    Console.WriteLine("digite o valor da compra:");
    double p = double.Parse(Console.ReadLine());
    Console.WriteLine("digite a quantidade de prestações:");
    int a = int.Parse(Console.ReadLine());
    Compra x = new Compra();
    x.SetTotal(p);
    x.SetNumPrestacoes(a);
    Console.WriteLine(GetValorPrestacao);
    Console.WriteLine(GetValorDesconto);
  }
}

class Compra{
  private double x;
  private int y;
  public void SetTotal(double r){
    if (r > 0)
      x = r;
  }
  public void SetNumPrestacoes(double r){
    if (r > 0)
      y = r;
  }
  public double GetValorPrestacao(){
    if (y > 1)
      double valor = x/y; 
      return valor;
  }
  public double GetValorDesconto(){
    if (y == 1)
      double valorc = x * 0.15;
      return valorc;
  }
}