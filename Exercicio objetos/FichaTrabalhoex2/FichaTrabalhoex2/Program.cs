using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaTrabalhoex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "monitor";
            string y = "teclado";

            Console.WriteLine("Devolver parte de monitor: " + x.Substring(0,1));

            Console.WriteLine("Devolver parte do teclado: " + y.Substring(y.Length-1, 1));
            
            Console.WriteLine("Devolver parte do monitor: " + x.Substring(1));

            Console.WriteLine("Treceiro elemento do monitor: " + x.Substring(3, 1));

            Console.WriteLine("Os tres primeiros elementos da variavel teclado: " + y.Substring(3, 0));

            Console.WriteLine("Os tres ultimos elementos de teclado: " + y.Substring(y.Length - 3, 3));

            Console.ReadKey();
        }
    }
}
