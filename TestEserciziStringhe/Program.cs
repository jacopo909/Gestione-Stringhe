using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestEserciziStringhe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("scrivi la 1 ° frase: ");
            string frase1 = Console.ReadLine();
            Console.WriteLine("scrivi una 2 ° frase: ");
            string frase2 = Console.ReadLine();

            
            if (string.IsNullOrEmpty(frase1))//IsNullOrEmpty serve per controllare se la frase riulta 0 (che significa vuota)
            {
                Console.WriteLine("non hai inserito niente ");
            }
            else
            {
                frase1 = frase1.ToLower();
                frase2 = frase2.ToLower();
                if(frase1 == frase2)
                {
                    Console.WriteLine("le frasi sono uguali ");
                }
                else
                {
                    Console.WriteLine("le frasi non sono uguali ");
                }
            }
                Console.ReadKey(); 
        }
    }
}
