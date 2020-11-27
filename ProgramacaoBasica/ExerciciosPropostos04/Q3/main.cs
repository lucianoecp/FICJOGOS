using System;


namespace Quest3
{
    class Program
    {
       static void Main(string[] args){
  Console.WriteLine("Este programa permite calcular o MDC\n");
  Console.Write("Informe o primeiro número: ");
  int x = int.Parse(Console.ReadLine());
 
  Console.Write("Informe o primeiro número: ");
  int y = int.Parse(Console.ReadLine());
 
  Console.WriteLine("\nO Máximo Divisor Comum de "
    + x + " e " + y + " é " + MDC(x, y));
 
  Console.WriteLine("\nPressione qualquer tecla para sair...");
  // pausa o programa
  Console.ReadKey();
}
 
public static int MDC(int a, int b){
  int resto;
 
  while(b != 0){
    resto = a % b;
    a = b;
    b = resto;
  }
 
  return a;
}
    }
}