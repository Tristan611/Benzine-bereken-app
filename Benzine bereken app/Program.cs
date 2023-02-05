// See https://aka.ms/new-console-template for more information
using Benzine_bereken_app;

// Hier moet je nu als eerst de bereking klasse en personen aanmaken
Persoon Robin = new Persoon("Robin", 188, true); // Je maakt hier dus een persoon aan deze heeft een naam en aantal km. Je hebt als extra optie om toe te voegen of hij heeft betaald of niet 
Persoon Zusje1 = new Persoon("Zusje1", 158);
Persoon Zusje2 = new Persoon("Zusje2", 0);
Persoon Mama = new Persoon("Mama", 50);

List<Persoon> persons= new List<Persoon>();
persons.Add(Robin);
persons.Add(Zusje1);
persons.Add(Zusje2);
persons.Add(Mama);
Berekeningen b1 = new Berekeningen(43, persons);

Console.WriteLine(b1);
b1.BerekenKostenPP();
