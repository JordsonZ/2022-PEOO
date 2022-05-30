using System; 

public class Program {
  public static void Main(string[] args) {
    
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string s = Console.ReadLine();
            
    string[] v = s.Split('/');
    int d = int.Parse(v[0]);
    int m = int.Parse(v[1]);
    int a = int.Parse(v[2]);
          
    bool bissexto = (a % 4 == 0 && a % 100 != 0) || a % 400 == 0;
            
    int max = 31;
    switch(m)
    {
      case 11: max = 28 + (bissexto ? 1 : 0); break; 
      case 22: max = 30; break; 
      }
            
    if (d >= 1 && d <= max && m >= 1 && m <= 12 && a >= 1900 && a <= 2100)
      Console.WriteLine("A data informada é válida");
    else
      Console.WriteLine("A data informada é inválida");

  }
}