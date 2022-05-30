using System; 

public class Program {
  public static void Main(string[] args) {

    Console.WriteLine("Digite o horário no formato hh:mm");
    string s = Console.ReadLine();
            
    int h = int.Parse(s.Substring(0, 2));
    int m = int.Parse(s.Substring(3, 2));
            
    double pm = m * 6;
            
    double ph = h * 30 + m * 0.5;
      
    ph = ph % 360;
            
    double angulo = ph > pm? ph - pm : pm - ph;
          
    if (angulo > 180) angulo = 360 - angulo;
    Console.WriteLine($"Menor ângulo entre os ponteiros = {angulo} graus");

  }
}