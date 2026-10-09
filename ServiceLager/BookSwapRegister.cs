using System;
using System.Collections.Generic;
using Models;

namespace ServiceLager
{
    public class BookSwapRegister
    {
        private List<Annons> Annonser { get; }
        private List<Affar> Affarer { get; }
        private List<Anvandare> Anvandare { get; }
        private List<Kurs> Kurser { get; }

        public BookSwapRegister()
        {
            Annonser = new List<Annons>();
            Affarer = new List<Affar>();
            Anvandare = new List<Anvandare>();
            Kurser = new List<Kurs>();
        }

        // ---- Nya metoder ----

        public void LaggTillAnvandare(Anvandare nyAnvandare)
        {
            Anvandare.Add(nyAnvandare);
        }

        public Anvandare HittaAnvandareViaEpost(string epost)
        {
            foreach (Anvandare aktuellAnvandare in Anvandare)
            {
                if (string.Equals(aktuellAnvandare.Kontouppgifter.Epostadress, epost,
                        StringComparison.OrdinalIgnoreCase))
                {
                    return aktuellAnvandare;
                }
            }

            return null;
        }

        public void LaggTillKurs(Kurs nyKurs)
        {
            Kurser.Add(nyKurs);
        }

        // ---- Dina befintliga metoder ----

        public void LaggTillAnnons(Annons nyAnnons)
        {
            Annonser.Add(nyAnnons);
        }

        public List<Annons> HamtaTillgangligaAnnonser()
        {
            List<Annons> tillgangliga = new List<Annons>();

            foreach (Annons aktuellAnnons in Annonser)
            {
                if (aktuellAnnons.Status == AnnonsStatus.TillSalu)
                {
                    tillgangliga.Add(aktuellAnnons);
                }
            }

            return tillgangliga;
        }

        public void LaggTillAffar(Affar affar)
        {
            Affarer.Add(affar);
        }
    }
}