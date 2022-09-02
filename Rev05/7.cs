using System; 

class Program {
  public static void AntecessorSucessor (int x, out int antecessor, out int sucessor){
    antecessor = x-1;
    sucessor = x+1;
  }
  public static void Main(){
    int a, b;
    Console.WriteLine("Digite um Número");
    int x = int.Parse(Console.ReadLine());
    AntecessorSucessor(x, out a, out b);

    Console.WriteLine(a);
    Console.WriteLine(b);
  }   
}