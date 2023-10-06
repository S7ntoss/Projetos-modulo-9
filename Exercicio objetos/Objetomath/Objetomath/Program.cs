using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaTrabalho2ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pow: {0}", Math.Pow(4d, 6d));
            Console.WriteLine("Round: {0}", Math.Round(5.68d, 1));
            Console.WriteLine("PI: {0}", Math.PI);
            Console.WriteLine("Raiz Quadrada: {0}", Math.Sqrt(5));
            Console.WriteLine("Retorne o menor valor acima de um número inserido, {0}", Math.Floor(4.6));
            Console.WriteLine("Retorne o maior valor acima de um número inserido, {0}", Math.Ceiling(6.7));
            Console.WriteLine("Retorne o valor mínimo de dois números inseridos, {0}", Math.Min(3, 9));
            Console.WriteLine("Retorne o valor máximo de dois números inseridos, {0}", Math.Max(6, 9));



            Console.ReadKey();  
        }
    }
}
