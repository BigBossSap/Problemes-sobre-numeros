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

            int num;
            int suma = int.MaxValue;
            int num2 = 0;
            int aux = 0;
            int contador = 0;
            

            Console.WriteLine("num: ");
            num = int.Parse(Console.ReadLine());
            int num1 = 0;


            while (num<=suma)
            {
                
                num2 = num;
                contador++;
                
                num1 = num;
                suma = num1 + num2;
                num = int.Parse(Console.ReadLine());
                Console.WriteLine(suma);

                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num);
                
            }

            Console.WriteLine($"Els valors que han complert la condicio son {num1} i {num2}");

        }
    }
}
