using System;

class Program{
  public static void Main(){
    double a = 2.5;
    double b = 5;
    double c = 8;
    double d = Maior(a, b, c);
    Console.WriteLine(d);
  }
  
  public static double Maior(double x, double y, double z){
    if (x > y && x > z) return x;
    else
      if (y > x && y > z) return y;
      else
        if (z > x && z > y) return z;
  }
}