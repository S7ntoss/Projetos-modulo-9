using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = " Progamacão em c#"; 

            Console.WriteLine("Tamanho: " +  frase.Length);

            Console.WriteLine("Maiuscula: " + frase.ToUpper());

            Console.WriteLine("Minucula: " + frase.ToLower());

            Console.WriteLine("Retirar espaço no inicio: " + frase.TrimStart());

            Console.WriteLine("replace de parte da string: " + frase.Replace("c#", "C#, by AEB"));

            Console.WriteLine("Devolver parte de string: " + frase.Substring(15));

            Console.WriteLine("Devolver string com uma parte removida: " + frase.Remove(frase.IndexOf("c#")-1));

            Console.WriteLine("Concatenar a string: " + string.Concat(frase, "-PSI"));

            Console.WriteLine(frase == "Programacão em c#");

            Console.WriteLine(frase.Equals("Programacão em c#, StringComparison.ordinal"));

            Console.ReadKey();
        }
    }
}
