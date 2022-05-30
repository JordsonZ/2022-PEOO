using System;

public class MainClass{
	public static void Main (string[] args){

    Console.WriteLine("Digite três valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
            
    int x = a;    
    if (b < x) x = b; 
    if (c < x) x = c; 
    
    int y = a;
    if (b > y) y = b; 
    if (c > y) y = c; 
    
      int t = x + y;
    
      Console.WriteLine($"A soma do maior com o menor número é {t}");
            
  }
}