using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzine_bereken_app
{
	public class Persoon
	{
		public string Naam { get; set;}
		public double AantalKM { get; set; }
		public bool Betaald { get; set; } = false;
		public Persoon(string naam, double aantalKM)
		{
			Naam = naam;
			AantalKM = aantalKM;
		}
		public Persoon(string naam, double aantalKM, bool betaald)
		{
			Naam = naam;
			AantalKM = aantalKM;
			Betaald = betaald;
		}
	}

}
