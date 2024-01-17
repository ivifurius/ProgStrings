using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str1 = "No hi ha res més important que el superflu";
            string str2 = "import";

            int posicio = -1;
            int i = 0;

            while (i <= str1.Length - str2.Length && posicio == -1)
            {
                int j = 0;

                while (j < str2.Length && str1[i + j] == str2[j])
                {
                    j++;
                }

                if (j == str2.Length)
                {
                    posicio = i;
                }

                i++;
            }

            if (posicio != -1)
            {
                Console.WriteLine($"{str2} s'ha trobat a la posició {posicio} dins de {str1}");
            }
            else
            {
                Console.WriteLine($"{str2} no s'ha trobat dins de {str1}");
            }

            Console.ReadKey();
        }
    }
}
