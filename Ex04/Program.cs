using System;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Donada una sèrie de nombres acabada en zero, fer un programa que ens
  digui si aquesta sèrie està formada únicament per valors positius. 
  */


            int num;
            int comparador = int.MinValue;
            bool positiu = false;


            Console.WriteLine("num: ");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {

                if (num < 0)
                    positiu = true;

                



                num = int.Parse(Console.ReadLine());

            }

            if (positiu)
                Console.WriteLine("No son tots positius");
            else
                Console.WriteLine("Son tots positius");




        }
    }
}
