using System;

class Program {
  public static void Main(){
  
    Console.WriteLine("Digite o número de alunos:");
    int i = int.Parse(Console.ReadLine());
    int j = 1;
    int soma = 0;
    Console.WriteLine("Digite a(s) nota(s) do(s) aluno(s):");
    while(j <= i){
      int o = int.Parse(Console.ReadLine());
      soma = soma + o;
      j++;
    }
    int r = soma/i;
    Console.WriteLine("Média da(s) nota(s) = " + r);
  }
}
    