using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Kompendium : Annons
    {
        public int AntalSidor { get; private set; }
        public int UtgivningsÅr { get; private set; }

        public Kompendium(
            Student säljare,
            Kurs kurs,
            string titel,
            decimal pris,
            AnnonsSkick skick,
            DateTime publiceringsdatum,
            int antalSidor,
            int utgivningsÅr)
            : base(säljare, kurs, titel, pris, skick, publiceringsdatum)
        {
            AntalSidor = antalSidor;
            UtgivningsÅr = utgivningsÅr;
        }
    }
}
