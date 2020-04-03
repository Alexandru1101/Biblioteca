using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
		static IStocareData stocare = new Acces_fisier("data.txt");

        static void Main(string[] args)
        {
			Carte c = stocare.Cautare("test");
			c.DisplayInfo();
			var c4 = CitireCarteTastatura();
			stocare.Editare(c.Nume, c4);
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
