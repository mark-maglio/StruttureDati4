using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Strutture_Dati_4
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            HashSet<double> lista = new HashSet<double>();
            Console.WriteLine("Inserisci un numero e ti dirò se è presente nel file di testo");
            double n = double.Parse(Console.ReadLine());
            using (StreamReader sr = new StreamReader("file.txt", Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lista.Add(double.Parse(line)); 
                }
            }
            bool state = false;
            foreach (double f in lista)
            {
                if (f == n)
                {
                    state = true;
                }
            }
            if (state == true)
            {
                Console.WriteLine("Il numero è contenuto nella lista");
            }
            else
            {
                Console.WriteLine("Il numero non è contenuto nella lista");
            }
            Console.ReadLine();
        }
    }
}