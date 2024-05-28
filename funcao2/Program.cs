using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segudo numero");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação ");
            string operacao= Console.ReadLine();

            funcao(n1, n2, operacao);
            Console.ReadKey();
        }
        static void funcao(double n1, double n2, string operacao)
         { 
            
            if (operacao == "+") { 
                   double resultado = n1 + n2;
                    Console.WriteLine("O resultado é: " + resultado);
                    }
                  

             else if (operacao == "-")
            {   
                    double resultado = n1 - n2;
                    Console.WriteLine("O resultado é: " + resultado);
                     }

            else if (operacao == "*")
            {
                double resultado = n1 * n2;
                Console.WriteLine("O resultado é: " + resultado);
            }
            else if (operacao == "/")
            {
                double resultado = n1 / n2;
                Console.WriteLine("O resultado é: " + resultado);
            }
            else 
            {
                Console.WriteLine("Algo deu errado");
            }





        }
            

        
        
    }
}
