using System;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fer un programa que permeti la introducció d’una sèrie de números fins que
  un d’aquests números sigui major que la suma dels dos números anteriors.
  Al finalitzar, ha de dir el número d'introduccions i valors dels números que
  han complert la condició de finalització del programa.*/

            int seguent;
            int suma = int.MaxValue;          
            int anterior = 0;
            int anterior2 = 0;
            int contador = 0;
            

            Console.WriteLine("num: ");
            anterior = int.Parse(Console.ReadLine());



            do
            {
                seguent = int.Parse(Console.ReadLine());               
                contador++;
                suma = anterior + seguent;
                anterior2 = anterior;
                anterior = seguent;
                
                seguent = int.Parse(Console.ReadLine());
                

            } while (seguent <= suma);

            Console.WriteLine($"Els valors que han complert la condicio son {anterior2} i {anterior} que sumen {suma} i el numero {seguent} es major");

        }
    }
}
