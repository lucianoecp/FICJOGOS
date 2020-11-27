using System;


namespace Quest1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;

            Console.Write("Informe o ano (a partir de 1001): ");
            ano = int.Parse(Console.ReadLine());

            if(ano < 1001) 
            {
                Console.WriteLine("[ERRO!] - Entrada inválida!\n");
                Console.WriteLine("Informe um ano válido a partir do ano 1001");
            }
            else if ((ano % 4 == 0) && ((ano % 100 != 0) || (ano % 400 == 0)))
            {
                Console.WriteLine("\nO ano "+ano+" é bissexto\n");
            }
            else
            {
                Console.WriteLine("\nO ano " + ano + " não é bissexto\n");
            }
        }
    }
}