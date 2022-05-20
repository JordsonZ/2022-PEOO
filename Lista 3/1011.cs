using System;

public class Program {
  public static void Main(string[] args) {
    
    double pi = 3.14159;
    double raio = double.Parse(Console.ReadLine());
    double VOLUME = (4.0 / 3.0) * pi * raio * raio * raio;
    
    Console.WriteLine("VOLUME = {0:F3}",VOLUME);

  }
}