using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class DigitalResurs : Annons
    {
        public string Filformat { get; private set; }
        public string Leveranssätt { get; private set; }

        public DigitalResurs(
            Student säljare,
            Kurs kurs,
            string titel,
            decimal pris,
            AnnonsSkick skick,
            DateTime publiceringsdatum,
            string filformat,
            string leveranssätt)
            : base(säljare, kurs, titel, pris, skick, publiceringsdatum)
        {
            Filformat = filformat;
            Leveranssätt = leveranssätt;
        }
    }
}
