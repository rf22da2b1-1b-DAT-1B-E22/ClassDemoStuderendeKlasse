// See https://aka.ms/new-console-template for more information
using ClassDemoStuderendeKlasse;



Studerende studerende1 = new Studerende(); // laver objekt + kalder konstruktør
            // opretter en reference til et nyt objekt af klassen Studerende
UdskrivStuderende(studerende1); // udskriv 1

studerende1.StudieId = "DAT2345";
studerende1.Fornavn = "Jakob";
studerende1.Efternavn = "Christensen";
studerende1.Uddannelse = "Datamatiker";

UdskrivStuderende(studerende1); // udskriv 2

studerende1.ÆndreFornavn("Peter");
UdskrivStuderende(studerende1); // udskriv 3


// Laver et nyt objekt
Studerende studerende2 = new Studerende("DAT3322", "Peter", "Levinsky", "Datamatiker");
UdskrivStuderende(studerende2); //udskriv 4





// Laver en ny skoleklasse
SkoleKlasse klasse = new SkoleKlasse();


klasse.AddStuderende(studerende1);
klasse.AddStuderende(studerende2);

Studerende findStuderende = klasse.FindStuderende("DAT3322");
Console.WriteLine(findStuderende);

findStuderende = klasse.FindStuderende("FindesIkke");
Console.WriteLine(findStuderende);

Console.WriteLine(klasse); // hele klassen

Studerende slettet = klasse.SletStuderende("DAT3322");
Console.WriteLine("Denne studerende er slettet " + slettet);
Console.WriteLine("hele klassen");
Console.WriteLine(klasse); // hele klassen








void UdskrivStuderende(Studerende s)
{
    Console.WriteLine($"Id={s.StudieId}, Navn={s.Fornavn} {s.Efternavn} går på uddannelse {s.Uddannelse}");
}