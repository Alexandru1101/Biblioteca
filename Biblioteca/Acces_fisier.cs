using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca
{
	class Acces_fisier : IStocareData
	{
		private string filename;
		public List<Carte> Carti;
		public Carte Cautare(string Titlu)
		{
			foreach (var item in Carti)
			{
				if (item.Nume == Titlu)
					return item;
			}
			return null;
		}

		public void Editare(string titlu, Carte c1)
		{

			for(int i=0;i<Carti.Count;i++)
			{
				if (Carti[i].Nume == titlu)
					Carti[i] = c1;
			}
		}

		public Acces_fisier(string filename)
		{ this.filename = filename;
			Carti = new List<Carte>();
			using (StreamReader sr = new StreamReader(filename))
			{
				while(!sr.EndOfStream)
				{
					Carti.Add(new Carte(sr.ReadLine()));
				}
			}
		}
		 ~Acces_fisier()
		{
			using (StreamWriter sw = new StreamWriter(filename))
			{
				foreach (var item in Carti)
				{
					sw.WriteLine(item.ToString());

				}
			}
		}
		public void Add(Carte c1)
		{
			Carti.Add(c1);
		}
	}
}
