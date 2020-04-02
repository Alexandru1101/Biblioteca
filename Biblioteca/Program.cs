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
            var c1 = new Carte("Ion", "Rebreanu", 15,4);
            c1.DisplayInfo();
            var c2 = new Carte();
            c2.DisplayInfo();
            var c3 = new Carte("Lotr,J.R.R Tolkien ,8,7");
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

			Console.WriteLine("Selectati genul");
			Console.WriteLine("1 -Carte politista \n" +
							  "2 - Carte pentru copii \n" +
							  "3 - Carte horror, \n" +
							  "4 - Literatura clasica \n" +
							  "5 - Poezie \n" +
							  "6 - SF \n"+
							  "7 - Fantasy \n");
			int opt = Convert.ToInt32(Console.ReadLine());

			Carte c = new Carte(nume, autor, nr_ex,opt);
            return c;
        }
    }
}
