using System; 

public class Program {
  public static void Main(string[] args) {

    Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
    
    string s = Console.ReadLine();
    
    int p = s.IndexOf('+');         
    if (p == -1) p = s.IndexOf('-'); 
    if (p == -1) p = s.IndexOf('*'); 
    if (p == -1) p = s.IndexOf('/'); 
    
    int x = int.Parse(s.Substring(0, p));
    int y = int.Parse(s.Substring(p + 1)); 
    int k = 0;
    
    switch(s[p])
    {
      case '+': k = x + y; break;
      case '-': k = x - y; break;
      case '*': k = x * y; break;
      case '/': k = x / y; break;
    }
    Console.WriteLine($"O resultado da operação é {k}");

  }
}