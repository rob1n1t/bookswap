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
            Student saljare,
            Kurs kurs,
            string titel,
            decimal pris,
            AnnonsSkick skick,
            DateTime publiceringsdatum,
            string filformat,
            string leveranssätt)
            : base(saljare, kurs, titel, pris, skick, publiceringsdatum)
        {
            Filformat = filformat;
            Leveranssätt = leveranssätt;
        }
    }
}
