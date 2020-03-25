using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("scrivi una frase , limite di 100 caratteri ");
            string frase = Console.ReadLine();
            frase.ToLower();
            Console.WriteLine(frase);
            string[] words = frase.Split(new char[] { ' ', ',', '.', ';' });//con String.Split divido la frase (Con "new char[] {qui ci metto i separatori che volgio io})
            foreach(string i in words)//string i è un contatore che legge tutta la stringa o vettore o lista
            {
                if (i.Trim() != "")//trim lo riunisce tutto
                    Console.WriteLine(i);
            }

            Console.WriteLine(frase);
            Console.ReadKey();
            
             
        }
    }
}
