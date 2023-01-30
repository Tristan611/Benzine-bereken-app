using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzine_bereken_app
{

	public class Berekeningen
	{
		int TotaalTank { get; set; } = 0;
		float TotaalKM { get; set; } = 0;
		internal string betalingPersoon;

		List<Persoon> Personen = new List<Persoon>();

		public Berekeningen(int totaalTank, List<Persoon> personen)
		{
			TotaalTank = totaalTank;
			Personen = personen;
		}

		public override string ToString()
		{
			return $"Totaal kosten van de tank waren {TotaalTank} euro's";
		}

		public string BerekenKostenPP()
		{
			foreach (Persoon o in Personen)
			{
				if (o.Betaald)
				{
					betalingPersoon = o.Naam;
				}
				TotaalKM += o.AantalKM;
			}
			foreach (Persoon o in Personen)
			{
				double Persoonsbedrag = Math.Round((double)((o.AantalKM / TotaalKM) * TotaalTank), 2, MidpointRounding.ToZero);

				if (o.Betaald != true)
				{
					Console.WriteLine($"{o.Naam} moet {Persoonsbedrag} euro betalen aan {betalingPersoon}");
				}
				else
				{
					Console.WriteLine("Je hebt zelf betaald dus mag de tikkies versturen. had " + Persoonsbedrag);
				}
			}
			return "";
		}
	}
}

