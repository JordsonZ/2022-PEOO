using System;

class Program {
  public static string Vogais(string s){
    string x = "";
    foreach(char c in s)
      if (c == 'a' || c == 'e' || c == 'i' || c== 'o' || c == 'u')
        return x;
  }
  public static void Main(){
    Console.WriteLine("Digite um texto");
    string s = Console.ReadLine();
    Console.WriteLine(Vogais(s));
  }
}