using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Feu un programa que trobi totes les lletres a que hi ha en un string.

            string paraula = "Paella";
            paraula.ToLower();
            bool trobat = false;
            int cont = 0;

            for (int i = 0; i < paraula.Length; i++)
            {
                if (paraula[i] == 'a')
                {
                    cont++;
                }
            }

            Console.WriteLine("Total de lletres 'a' trobades: " + cont);

            Console.ReadKey();
        }
    }
}
