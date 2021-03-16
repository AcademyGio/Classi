using System;   // posso omettere System quando mi riferisco a tipi contenuti
                // nel namespace System

namespace Classi
{
    class Program
    {
        static void Metodo()
        {

        }

        static void Main(string[] args)
        {
            //Program ist = new Program();
            //ist.Metodo();

            Metodo();

            Conto c = new Conto();
            Conto c2 = new Conto();

            double rad5 = Math.Sqrt(5);
            Console.WriteLine();

            c.Versa(1000.45M);
            c.Versa(500M);
            c.Preleva(700M);

            c2.Versa(1000);

            // c.saldo = 1000000;   // non posso accedere a un campo privato
            // c.Saldo = 1000000;   // la proprietà Saldo è di sola lettura

            Console.WriteLine(c.Saldo);
            Console.WriteLine(c2.Saldo);

            Persona p = new Persona("Selene", "Tucciarone", new DateTime(1990, 6, 20));  // chiamata al default constructor
            Persona p1 = new Persona("Elvira", "Tucciarone", new DateTime(1990, 6, 20));  // chiamata al default constructor
            Persona p2 = new Persona("Graziella", "Tucciarone", new DateTime(1990, 6, 20));  // chiamata al default constructor

            //            p.Nome = "Selene";
            //            p.Cognome = "Tucciarone";
            //            p.DataNascita = new DateTime(1990, 6, 20);

            Console.WriteLine(p.DatiAnagrafici);
            Console.WriteLine(p1.DatiAnagrafici);
            Console.WriteLine(p2.DatiAnagrafici);
        }
    }
}
