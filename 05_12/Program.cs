using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string paraula = "No soc un complet inútil,* si més no, serveixo *de mal exemple.";

            // Convertir la cadena a un arreglo de caracteres
            char[] caracteres = new char[paraula.Length];

            for (int i = 0; i < paraula.Length; i++)
            {
                caracteres[i] = paraula[i]
            }

            // Iterar sobre los caracteres y realizar el reemplazo directamente
            for (int i = 0; i < caracteres.Length; i++)
            {
                if (caracteres[i] == '*')
                {
                    caracteres[i] = '\n';
                }
            }

            
            Console.WriteLine(caracteres);

            Console.ReadKey();
        }
    }
}
