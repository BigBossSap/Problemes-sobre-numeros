using System;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escriure un programa que faci una còpia d’una seqüència de caràcters
   acabada en punt, però suprimint tots els espais en blanc. */


            char frase;
            string completa = "";

            Console.WriteLine("frase: ");
            frase = Console.ReadKey().KeyChar;

            do
            {



                if (frase == ' ')
                {


                    while (frase == ' ')
                    {
                        frase -= ' ';
                        frase = Console.ReadKey().KeyChar;
                    }
                }

                completa = completa + frase;
                frase = Console.ReadKey().KeyChar;
            } while (frase != '.');

            Console.WriteLine(completa);
        }
    }
}
