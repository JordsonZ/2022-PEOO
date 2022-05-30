using System; 

public class Program {
  public static void Main(string[] args) {

    Console.WriteLine("Informe o número do mês");
    int m = int.Parse(Console.ReadLine());
          
    switch (m)
      {
        case 1: Console.WriteLine("O mês de janeiro é do primeiro trimestre do ano"); break;
        case 2: Console.WriteLine("O mês de fevereiro é do primeiro trimestre do ano"); break;
        case 3: Console.WriteLine("O mês de março é do primeiro trimestre do ano"); break;
        case 4: Console.WriteLine("O mês de abril é do segundo trimestre do ano"); break;
        case 5: Console.WriteLine("O mês de maio é do segundo trimestre do ano"); break;
        case 6: Console.WriteLine("O mês de junho é do segundo trimestre do ano"); break;
        case 7: Console.WriteLine("O mês de julho é do terceiro trimestre do ano"); break;
        case 8: Console.WriteLine("O mês de agosto é do terceiro trimestre do ano"); break;
        case 9: Console.WriteLine("O mês de setembro é do terceiro trimestre do ano"); break;
        case 10: Console.WriteLine("O mês de outubro é do quarto trimestre do ano"); break;
        case 11: Console.WriteLine("O mês de novembro é do quarto trimestre do ano"); break;
        case 12: Console.WriteLine("O mês de dezembro é do quarto trimestre do ano"); break;
        }      
  }
}
  enum mes
    {
      janeiro = 1, fevereiro, março, abril, maio, junho, julho, agosto,
      setembro, outubro, novembro, dezembro
    }
    enum trimestre { primeiro = 0, segundo, terceiro, quarto }
