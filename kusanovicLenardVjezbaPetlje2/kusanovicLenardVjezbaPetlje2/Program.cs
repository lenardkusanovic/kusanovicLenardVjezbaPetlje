using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardVjezbaPetlje2
{
    class Program
    {
        static void Main(string[] args)
        {

            string unosTeksta;

            Console.WriteLine("Unesi tekst: ");

            unosTeksta = Console.ReadLine();

            for (int i = unosTeksta.Length; i>0; i--)
            {
                Console.WriteLine(unosTeksta.Substring(0, i));
            }

            Console.ReadKey();

        }
    }
}
