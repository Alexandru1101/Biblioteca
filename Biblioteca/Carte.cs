using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Carte
    {
        
        private string nume, autor;
        private int nr_exemplare;
        public Carte()
                {
                    nume =string.Empty;
                    autor =string.Empty;
                    nr_exemplare = 0;

                }

        public Carte(string n, string a, int nr)
                {
                    nume = n;
                    autor = a;
                    nr_exemplare = nr;
                }

        //Tema 3
        public Carte(string sir)
        {
            string[] buff = sir.Split(',');
            nume = buff[0];
            autor = buff[1];
            nr_exemplare = Convert.ToInt32(buff[2]);


        }
        //Tema 3

        //Tema 4
        public string Nume { get; set; }
        public string Autor { get; set; }
        public string NrExemplare { get; set; }
        //Tema 4
        public void DisplayInfo()
        {
            System.Console.WriteLine("Nume\tAutor\tNr.Exemplare");
            System.Console.WriteLine(nume + "\t" + autor + "\t" + nr_exemplare);
        }
    }
}

