using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Feu un programa que trobi si hi ha alguna lletra a en un string

            string paraula = "Paella";
            paraula.ToLower();
            bool trobat = false;
            int i  = 0;


            while (i < paraula.Length && !trobat)
            {
                if (paraula[i] == 'a')
                {
                    trobat = true;
                }
                i++;
            }

            if (trobat)
            {
                Console.WriteLine(paraula + " si conté la lletra a");
            }

            Console.ReadKey();
        }
    }
}
