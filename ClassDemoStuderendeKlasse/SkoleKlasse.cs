using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoStuderendeKlasse
{
    public class SkoleKlasse
    {
        // ingen properties


        // instans felt til relation til Studerende
        private List<Studerende> _studerende;

        // konstruktør
        public SkoleKlasse()
        {
            _studerende = new List<Studerende>();
        }

        /*
         * Metoder til bl.a. CRUD (Create, Read, Update og Delete)
        */
        public void AddStuderende(Studerende s)
        {
            _studerende.Add(s);
        }

        public Studerende ÆndreStuderende(Studerende s)
        {
            Studerende ændreStuderende = FindStuderende(s.StudieId);
            if (ændreStuderende is not null)
            {
                ændreStuderende.Fornavn = s.Fornavn;
                ændreStuderende.Efternavn = s.Efternavn; 
                ændreStuderende.Uddannelse = s.Uddannelse;
            }
            return ændreStuderende;
        }

        public Studerende SletStuderende(Studerende s)
        {
            Studerende slettet = s;
            _studerende.Remove(s);
            return slettet;
        }

        public Studerende SletStuderende(String id)
        {
            Studerende slettet = FindStuderende(id);
            if (slettet is not null)
            {
                _studerende.Remove(slettet);
            }
            return slettet;
        }

        public Studerende FindStuderende(string id)
        {
            foreach(Studerende s in _studerende)
            {
                if (s.StudieId == id)
                {
                    // fundet den rette
                    return s;
                }
            }

            // ikke fundet nogen
            return null;      // senere vil I returnere en exception
        }




        // ToString
        public override string ToString()
        {
            return $"Studerende i klassen = ({String.Join(", ", _studerende)})";
        }
    }
}
