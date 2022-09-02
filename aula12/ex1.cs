using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite um número:");
    int x = int.Parse(Console.ReadLine());

    int a = x / 365;
    int k = a - x * 365;
    int m = k / 30;
    int p = k - m * 30;
    int d = p;

    Console.WriteLine(a + "ano (s)");
    Console.WriteLine(m + "mes (es)");
    Console.WriteLine(d + "dia (s)");

  }
}