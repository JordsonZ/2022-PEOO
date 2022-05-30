using System; 

public class Program {
  public static void Main(string[] args) {
    string x = Console.ReadLine();
    int n = int.Parse(x);

    if (n == 61) Console.WriteLine("Brasilia");
    else
      if (n == 71) Console.WriteLine("Salvador");
      else
        if (n == 11) Console.WriteLine("Sao Paulo");
        else
          if (n == 21) Console.WriteLine("Rio de Janeiro");
          else
            if (n == 32) Console.WriteLine("Juiz de Fora");
            else
              if (n == 19) Console.WriteLine("Campinas");
              else
                if (n == 27) Console.WriteLine("Vitoria");
                else
                  if (n == 31) Console.WriteLine("Belo Horizonte");
                  else
                    if (n != 61 && n != 71 && n != 11 && n != 21 && n != 32 && n != 19 && n != 27 && n != 31) Console.WriteLine("DDD nao cadastrado");
  }
}