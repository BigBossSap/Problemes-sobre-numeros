using System;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fer un programa que a l’entrar N números enters, ens digui quants d’ells
   eren múltiples de 3 i quants més grans o iguals a 5. Cal tenir en compte que
   el zero no és múltiple de 3. 
   */


            int num, contadorMult = 0, contador5 = 0;

            Console.WriteLine("num: ");
            num= int.Parse(Console.ReadLine());

            while (num!=0)
            {

                if(num%3==0)
                {
                    contadorMult++; 
                }

                if (num>=5)
                {
                    contador5++;
                }
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Han aparegut {contador5} enters mes grans o iguals a 5");
            Console.WriteLine($"Han aparegut {contadorMult} multiples de 3");
        }
    }
}
