using System;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fer un programa, que després d’haver-li entrat N números positius, ens digui
 quin és el més petit, i quina posició ocupa dins la seqüència.*/


            int num;
            int comparador = int.MaxValue;
            int cicles = 0;
            bool pararContador = false;
            
            Console.WriteLine("num: ");
            num = int.Parse(Console.ReadLine());


            while (num!=0)
            {
                if (num < comparador) {
                    comparador = num;
                   
                    }

                if (num > comparador)
                    cicles++;

                num = int.Parse(Console.ReadLine());


            }

            Console.WriteLine(comparador);
            Console.WriteLine(cicles);

        }
    }
}
