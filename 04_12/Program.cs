using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "No hi ha un més enllà, cada dia que passa hi ha un menys aquí";
            string str2 = "hi ha";

            int count = 0;
            int i = 0;

            while (i < str1.Length - str2.Length + 1)
            {
                bool match = true;

                int j = 0;
                while (j < str2.Length && match)
                {
                    if (str1[i + j] != str2[j])
                    {
                        match = false;
                    }
                    j++;
                }

                if (match)
                {
                    count++;
                }

                i++;
            }

            Console.WriteLine($"El substring \"{str2}\" apareix {count} vegades a \"{str1}\".");

            Console.ReadKey();
        }
    }
}
