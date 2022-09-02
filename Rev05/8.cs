using System; 

class Program {
  public static int MenorInteiro(double x){
    int y = (int) x;
    if (x==y) return y;
    else return y+1;
  }
  public static void Main(){
    Console.WriteLine("Digite um numero");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine(MenorInteiro(x));
  }
}