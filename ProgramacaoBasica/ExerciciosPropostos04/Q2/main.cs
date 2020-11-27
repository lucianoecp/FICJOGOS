using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quest2
{
    class Program
    {

        static void Main(String[] Args)
        {
            int A;
            int B;
            int C;

            Console.WriteLine(" ");
            Console.Write("Lado A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.Write("Lado B: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.Write("Lado C: ");
            C = Convert.ToInt32(Console.ReadLine());

            if ((A<B+C) && (B<A+C) && (C<A+B))
            {
                Console.WriteLine(" ");

                Console.Write(
                  "Os lados informados formam um triângulo!");
				
				if ((A==B) && (B==C))
        {
					Console.WriteLine(" ");
					Console.Write("\nTipo de Triângulo: Equilátero");
				
				}else if ((A==B) || (B==C) || (A==C))
        {
					Console.WriteLine(" ");
					Console.Write("\nTipo de Triângulo: Isósceles");
				}else
        {
					Console.WriteLine(" ");
					Console.Write("\nTipo de Triângulo: Escaleno");
				}
				
            }else
            {
                Console.WriteLine(" ");
                Console.Write("Os lados não formam um triângulo!");
            }
            System.Console.ReadKey();
        }
    }

}