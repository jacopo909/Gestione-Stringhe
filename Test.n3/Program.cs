using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.n3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("scrivi una frase ");
            string frase = Console.ReadLine();
            
            if (string.IsNullOrEmpty(frase))//IsNullOrEmpty serve per controllare se la frase riulta 0 (che significa vuota)
            {
                Console.WriteLine("non hai inserito nessuna frase!");
            }
            else
            {
                frase = frase.ToLower();
                string[] words = frase.Split(new char[] { ' ', ',', '.', ';' });//con String.Split divido la frase (Con "new char[] {qui ci metto i separatori che volgio io})
                for(int i = 0; i < words.Length;i++)
                {
                    foreach (string n in words)
                    {
                       
                        Console.WriteLine("questa è n: " + n);
                    }

                    Console.WriteLine("questa è i: " + i);
                }
           
            }
            Console.ReadKey();
        }
    }
}
