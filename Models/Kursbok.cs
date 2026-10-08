using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Kursbok : Annons
    {
        public string ISBN { get; private set; }
        public string Författare { get; private set; }
        public int Upplaga { get; private set; }

        public Kursbok(
            Student säljare,
            Kurs kurs,
            string titel,
            decimal pris,
            AnnonsSkick skick,
            DateTime publiceringsdatum,
            string isbn,
            string författare,
            int upplaga)
            : base(säljare, kurs, titel, pris, skick, publiceringsdatum)
        {
            ISBN = isbn;
            Författare = författare;
            Upplaga = upplaga;
        }
    }
}
