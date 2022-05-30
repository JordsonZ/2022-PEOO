using System; 

public class Program {
  public static void Main(string[] args) {

    Console.WriteLine("Digite três valores");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
            
    int x;
        
    if (a > b)
    {       
    x = a;
    a = b;
    b = x;
    }
      
    if (a > c)
    {             
    x = a;
    a = c;
    c = x;
    }
            
    if (b > c)
    {         
    x = b;
    b = c;
    c = x;
    }
          
    Console.WriteLine($"{a}, {b}, {c}");

  }
}