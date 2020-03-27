using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Carte("titlu", "autor", 15);
            c1.DisplayInfo();
            var c2 = new Carte();
            c2.DisplayInfo();
            var c3 = new Carte("Ion,Rebreanu,8");
            c3.DisplayInfo();
            var c4 = CitireCarteTastatura();
            c4.DisplayInfo();
        

            Console.ReadKey();
        }

    public static Carte CitireCarteTastatura()
        {
            Console.WriteLine("Introduceti numele");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti autorul");
            string autor = Console.ReadLine();

            Console.WriteLine("Introduceti nr de exemplare");
            int nr_ex = Convert.ToInt32(Console.ReadLine());

            Carte c = new Carte(nume, autor, nr_ex);
            return c;
        }
    }
}
