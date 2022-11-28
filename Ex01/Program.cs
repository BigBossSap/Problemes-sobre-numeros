using System;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Donada una frase acabada en punt, fer un programa que compti el nombre
 de caràcters que hi apareixen, sense comptar el punt finalitzador. 
 */

            char lletra;
            int contador = 0;
            string frase = "";

            Console.WriteLine("Introdueix una frase acabada en punt: ");
            lletra = Console.ReadKey().KeyChar;

            while (lletra !='.')
            {

                if (lletra == ' ' || lletra == '.')
                {
                    contador--;
                    frase += lletra;
                }




                contador++;
                frase += lletra;
                lletra = Console.ReadKey().KeyChar;

            }

            Console.WriteLine($"\r La frase #{frase}# te {contador} caràcters.");

        }
    }
}
