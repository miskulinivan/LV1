using System;

namespace LV1
{
    class program
    {
        private static void Main(string[] args)
        {           //treci zadatak
            Zabiljeska zabiljeska1 = new Zabiljeska();           
            Console.WriteLine(zabiljeska1.getAutorZabiljeske());
            Console.WriteLine(zabiljeska1.getTekstZabiljeske());

            Console.WriteLine("\n");

            Zabiljeska zabiljeska2 = new Zabiljeska("zabiljeska 2", "Lav Nikolajevic Tolstoj");
            Console.WriteLine(zabiljeska2.getTekstZabiljeske());
            Console.WriteLine(zabiljeska2.getAutorZabiljeske());

            Console.WriteLine("\n");

            Zabiljeska zabiljeska3 = new Zabiljeska("zabiljeska 3", "Fjodor Mihajlovic Dostojevski", 3);
            Console.WriteLine(zabiljeska3.getTekstZabiljeske());
            Console.WriteLine(zabiljeska3.getAutorZabiljeske());
            Console.WriteLine(zabiljeska3.getRazinaVaznosti());

            Console.WriteLine("\n");

            Console.WriteLine(zabiljeska1.ToString());
            Console.ReadLine();                
        }
    }
}
