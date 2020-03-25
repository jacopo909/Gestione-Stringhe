using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci qualcosa");
            string prova = Console.ReadLine();
            
            Console.WriteLine("ai inserito  " + prova.ToLower() + " ciao " ) ;

            Console.ReadKey();
        }
    }
}
