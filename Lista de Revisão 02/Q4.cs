using System;

public class MainClass{
	public static void Main (string[] args){

    Console.WriteLine("Digite o primeiro horário no formato hh:mm");
    string x = Console.ReadLine();
    Console.WriteLine("Digite o segundo horário no formato hh:mm");
    string y = Console.ReadLine();
                    
    int h1 = int.Parse(x.Substring(0, 2));
    int m1 = int.Parse(x.Substring(3, 2));
            
    int h2 = int.Parse(y.Substring(0, 2));
    int m2 = int.Parse(y.Substring(3, 2));
            
    int h = h1 + h2;
    int m = m1 + m2;
            
    if (m > 60)
    {
      m -= 60;  
      h++;      
        }
    Console.WriteLine($"Total de horas = {h:00}:{m:00}");
  }
}