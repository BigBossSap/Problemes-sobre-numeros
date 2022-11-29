using System;
using System.Globalization;
using System.IO;
using System.Threading;

namespace Exercici_de_fitxers_1000000
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i=0;
            int loteria;
            int cont = 0;
            string linea = "";
            Random nums = new Random();

            StreamWriter fitxerW = new StreamWriter(@"C:\Users\sergi\source\repos\Problemes sobre numeros\Exercici de fitxers 1000000\resultats.txt");


            while (i < 1000000) {

                

                while (cont < 5)
                {
                    loteria = nums.Next(6, 49);


                    linea += loteria + " "; 
                    cont++;
                    

                }
                cont = 0;
                fitxerW.WriteLine($"{linea} ");
                linea = "";

                i++;
            }

            fitxerW.Close();
           

            





        }
    }
}
