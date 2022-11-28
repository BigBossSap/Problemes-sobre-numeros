using System;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Donada una sèrie de nombres acabada en zero, fer un programa que ens
  digui si aquesta sèrie és creixent. 
  */
            int num;
            int comparador = int.MinValue;
            bool decreixent = false;


            Console.WriteLine("num: ");
            num=int.Parse(Console.ReadLine());

            while (num!=0)
            {

                if (num<comparador)
                    decreixent = true;  

                comparador = num;



                num = int.Parse(Console.ReadLine());

            }

            if (decreixent)
                Console.WriteLine("No es creixent");
            else
                Console.WriteLine("Es creixent");



        }
    }
}
