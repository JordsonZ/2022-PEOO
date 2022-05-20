using System;

public class Program {
  public static void Main(string[] args) {

    int.TryParse(Console.ReadLine(), out int tempo);
    int.TryParse(Console.ReadLine(), out int velocidade);
    
    Console.WriteLine((velocidade * tempo / 12.0).ToString("F3"));

  }
}