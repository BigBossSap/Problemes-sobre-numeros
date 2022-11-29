using System;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fer un programa, que ens digui si un número donat és primer*/

            int num, i=1;
            int cont=0;
            Console.WriteLine("num: ");
            num = int.Parse(Console.ReadLine());

            while (i<=num)
            {
                

                if (num % i == 0)
                    cont++;

                i++;
                

            }
            if (cont == 2)
            Console.WriteLine("si");
            else
                Console.WriteLine("no");


        }
    }
}
