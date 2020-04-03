using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
	public enum Categorii
	{	Nedefinit=0,
		Carte_politista=1,
		Carte_pentru_copii=2,
		Carte_horror=3,
		Literatura_clasica=4,
		Poezie=5,
		SF=6,
		Fantasy=7

	}
    public class Carte
    {
        
        private string nume, autor;
		private Categorii gen;
        private int nr_exemplare;
        public Carte()
                {
                    Nume =string.Empty;
                    Autor =string.Empty;
                    NrExemplare = 0;
					Gen = Categorii.Nedefinit;
                }

        public Carte(string n, string a, int nr,int opt)
                {
                    Nume = n;
                    Autor = a;
                    NrExemplare = nr;
					Gen =(Categorii)opt;
                }

        //Tema 3
        public Carte(string sir)
        {
            string[] buff = sir.Split(',');
            nume = buff[0];
            autor = buff[1];
            nr_exemplare = Convert.ToInt32(buff[2]);
			gen=(Categorii)Convert.ToInt32(buff[3]);


		}
        //Tema 3

        //Tema 4
        public string Nume { get =>nume; set => nume = value; }
        public string Autor { get =>autor; set =>autor =value; }
        public int NrExemplare { get=> nr_exemplare; set=>nr_exemplare=value; }
		public Categorii Gen { get => gen; set => gen = value; }

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

		public override string ToString()
		{
			return $"{nume},{autor},{nr_exemplare},{(int) gen}";
		}
	}
}

