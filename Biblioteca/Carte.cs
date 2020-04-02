using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
	public enum Categorii
	{
		Carte_politista=1,
		Carte_pentru_copii=2,
		Carte_horror=3,
		Literatura_clasica=4,
		Poezie=5,
		SF=6,
		Fantasy=7

	}
    class Carte
    {
        
        private string nume, autor,gen;
        private int nr_exemplare;
        public Carte()
                {
                    nume =string.Empty;
                    autor =string.Empty;
                    nr_exemplare = 0;
					gen = string.Empty;
                }

        public Carte(string n, string a, int nr,int opt)
                {
                    nume = n;
                    autor = a;
                    nr_exemplare = nr;
					gen = Convert.ToString((Categorii)opt);
                }

        //Tema 3
        public Carte(string sir)
        {
            string[] buff = sir.Split(',');
            nume = buff[0];
            autor = buff[1];
            nr_exemplare = Convert.ToInt32(buff[2]);
			gen= Convert.ToString((Categorii)Convert.ToInt32(buff[3]));


		}
        //Tema 3

        //Tema 4
        public string Nume { get; set; }
        public string Autor { get; set; }
        public string NrExemplare { get; set; }
        //Tema 4
        public void DisplayInfo()
        {
            System.Console.WriteLine("Nume\tAutor\tNr.Exemplare\tGen");
            System.Console.WriteLine(nume + "\t" + autor + "\t" + nr_exemplare+ "\t"+gen);
        }


		public static bool operator ==(Carte a,Carte b)
		{
			if (a.Autor == b.autor && a.Nume == b.nume && a.nr_exemplare == b.nr_exemplare)
				return true;
			else return false;
		}

		public static bool operator !=(Carte a, Carte b)
		{
			if (a.Autor == b.autor && a.Nume == b.nume && a.nr_exemplare == b.nr_exemplare)
				return false;
			else return true;
		}

	}
}

