using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Models
{
    public abstract class Annons
    {
        public int AnnonsId { get; private set; }
        public Student Säljare { get; private set; }
        public Kurs Kurs { get; private set; }
        public string Titel { get; private set; }
        public decimal Pris { get; private set; }
        public AnnonsSkick Skick { get; private set; }
        public DateTime Publiceringsdatum { get; private set; }
        public AnnonsStatus Status { get; private set; }
        private static int nästaAnnonsId = 1;

        protected Annons(
            Student säljare,
            Kurs kurs,
            string titel,
            decimal pris,
            AnnonsSkick skick,
            DateTime publiceringsdatum)
        {
            AnnonsId = nästaAnnonsId++;
            Säljare = säljare;
            Kurs = kurs;
            Titel = titel;
            Pris = pris;
            Skick = skick;
            Publiceringsdatum = publiceringsdatum;
            Status = AnnonsStatus.TillSalu;
        }

        public bool KanReserverasAv(Student köpare)
        {
            return Status == AnnonsStatus.TillSalu && köpare != Säljare;
        }

        public void MarkeraSomReserverad()
        {
            if (Status != AnnonsStatus.TillSalu)
                throw new InvalidOperationException("Annonsen kan inte reserveras.");

            Status = AnnonsStatus.Reserverad;
        }

        public void UppdateraAnnonsUppgifter(
            Kurs kurs, 
            string titel,
            decimal pris,
            AnnonsSkick skick)

        {
            if (kurs == null)
            {
                throw new ArgumentException("En kurs måste väljas.");
            }

            if (string.IsNullOrWhiteSpace(titel))
            {
                throw new ArgumentException("Titel måste anges.");
            }

            if (pris <= 0)
            {
                throw new ArgumentException("Priset måste vara större än 0.");
            }

            Kurs = kurs;
            Titel = titel.Trim();
            Pris = pris;
            Skick = skick;
        }

        
    }
}
