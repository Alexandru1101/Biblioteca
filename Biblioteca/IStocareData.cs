using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
	public interface IStocareData
	{
		void Editare(string titlu, Carte c1);
		Carte Cautare(string Titlu);
		void Add(Carte c1);
	}
}
