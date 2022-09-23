using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoStuderendeKlasse
{
    public class Studerende
    {
        // UML attributter
        public String StudieId { get; set; } // dette er en property pga. get/set
        public String Fornavn { get; set; }
        public String Efternavn { get; set; }
        public String Uddannelse { get; set; }

        // UML metoder

        public void ÆndreFornavn(String nyNavn)
        {
            Fornavn = nyNavn;
        }


        // C# smarte 'metoder'
        /*
         * Konstruktører
         */
        public Studerende()
        {

        }

        public Studerende(String Id, String FNavn, String ENavn, String Uddannel)
        {
            StudieId = Id;
            Fornavn = FNavn;    
            Efternavn = ENavn;
            Uddannelse = Uddannel;
        }

    }
}
